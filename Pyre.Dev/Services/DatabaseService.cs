using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using Pyre.Dev.Models;
using Pyre.Dev.Models.Interfaces;

namespace Pyre.Dev.Services
{
    public class DatabaseService
    {
        private readonly PyreDevDbContext _db;

        public DatabaseService(PyreDevDbContext db)
        {
            _db = db;
        }
        // --- Get Data ---
        // All
        public async Task<List<T>> GetAllAsync<T>() where T : class, ITable
        {
            return await _db.Set<T>().ToListAsync();
        }
        // One By Id
        public async Task<T?> GetByIdAsync<T>(int id) where T : class, ITable
        {
            return await _db.Set<T>().FirstOrDefaultAsync(row => row.Id == id);
        }
        // --- Mutations ---
        // Add
        public async Task<(bool Success, string Error)> AddAsync(IFinanceTables payload)
        {
            if (!payload.Validate(out string error, out HashSet<string> InvalidFields))
                return (false, error);

            _db.Add(payload);
            await _db.SaveChangesAsync();
            return (true, "");
        }
        // Edit
        public async Task<(bool Success, string Error)> UpdateAsync(IFinanceTables payload)
        {
            if (!payload.Validate(out string error, out HashSet<string> InvalidFields))
                return (false, error);

            _db.Update(payload);
            await _db.SaveChangesAsync();
            return (true, "");
        }
        // Delete
        public async Task<(bool Success, string Error)> DeleteAsync(ITable payload)
        {
            _db.Remove(payload);
            await _db.SaveChangesAsync();
            return (true, "");
        }
    }
}