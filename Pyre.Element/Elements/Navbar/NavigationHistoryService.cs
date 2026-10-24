using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace Pyre.Element.Navbar;

/// <summary>
/// Tracks recently visited pages so the app can offer Back / Forward buttons.
/// </summary>
public sealed class NavigationHistoryService : IDisposable
{
    private const int MaxEntries = 5;

    private readonly NavigationManager _nav;
    private readonly List<string> _backStack = new();
    private readonly List<string> _forwardStack = new();

    private string _currentUrl;
    private bool _isHistoryNavigation;   // true while WE are driving a back/forward jump

    public bool CanGoBack => _backStack.Count > 0;
    public bool CanGoForward => _forwardStack.Count > 0;

    /// <summary>Raised whenever the stacks change, so UI can refresh button states.</summary>
    public event Action? Changed;

    public NavigationHistoryService(NavigationManager nav)
    {
        _nav = nav;
        _currentUrl = nav.Uri;
        _nav.LocationChanged += HandleLocationChanged;
    }

    public void GoBack()
    {
        if (!CanGoBack) return;

        Push(_forwardStack, _currentUrl);
        var target = Pop(_backStack);

        _isHistoryNavigation = true;
        _nav.NavigateTo(target);
    }

    public void GoForward()
    {
        if (!CanGoForward) return;

        Push(_backStack, _currentUrl);
        var target = Pop(_forwardStack);

        _isHistoryNavigation = true;
        _nav.NavigateTo(target);
    }

    private void HandleLocationChanged(object? sender, LocationChangedEventArgs e)
    {
        if (_isHistoryNavigation)
        {
            // Our own Back/Forward jump. The stacks were already updated in GoBack/GoForward.
            _isHistoryNavigation = false;
        }
        else
        {
            // A normal navigation (clicking a link or tab): remember where we came from,
            // and wipe Forward, the same as a browser does.
            Push(_backStack, _currentUrl);
            _forwardStack.Clear();
        }

        _currentUrl = e.Location;
        Changed?.Invoke();
    }

    /// <summary>Adds to the end of the list, dropping the oldest entry past the cap.</summary>
    private static void Push(List<string> stack, string url)
    {
        stack.Add(url);
        if (stack.Count > MaxEntries) stack.RemoveAt(0);
    }

    /// <summary>Removes and returns the most recent entry.</summary>
    private static string Pop(List<string> stack)
    {
        var url = stack[^1];
        stack.RemoveAt(stack.Count - 1);
        return url;
    }

    public void Dispose() => _nav.LocationChanged -= HandleLocationChanged;
}