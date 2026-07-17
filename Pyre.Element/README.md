# Pyre.Element
A Blazor Component Library with a focus on large-scale web applications using SQLite, inspired by Shadcn design philosophy.

# Development Format
## File Structure
### Elements
This is the main folder of the library. It holds all of the main Components, like buttons and inputs etc.
### Enums
This folder holds generic, global enums used in many components, such as eStatus.cs with the E_STATUS enum.
### Icons
/Icons holds all of the libraries Icon.razor files, and their variants.

## Component Layout
### Sections
Each component has 3 main sections. 

Section 1: Element - This is where the actual element is rendered, using all the info from the next two sections.

Section 2: Variables - these are split into 3 subbparts (Base, Pyre Base, Element Specific)
    Base: Base handles Render Fragments, and very common variables in RCLs.
    Pyre Base: Similar to base, except stuff that is slightly more unsual and specific to my RCL and format.
    Element Specific: Just hyper-specific things that don't really fit into either category

Section 3: Computed Classes & Styles - This is where the component takes in info from the variables in section 2, and then creates a
full computed class variable that is then rendered in the actual element.

Section 4 (optional): Logic Handling - This only exists on certain components like Inputs and Buttons and Dropdowns. 
Which is why it is optional


### Enums & Computed Variables
All enums when implemented into the element itself are to be stored in "_exampleField" variables that convert the Enum to a String 

## Syntax
### CSS Classes
Classes that are conditional on any logic whatsoever, are spaced with two dashes: "--"
Classes that are NOT conditional whatsoever, are soaced with two Underscores: "__"
Example: "this--is--conditional"
Example: "this__is__not__conditional"

# Implementation
What follows are a list of all the components in this small Blazor component library, inspired by Shadcn design philosophy.
Each component is designed specifically for large-scale web applications in mind, with lots of on-deck customizability, and feature set.

Furthermore, certain components like <FormSubmit/> are designed with SQLite Databases specifically in mind, as the Hearth application is
what this component library is specifically designed for, which runs exclusivly on SQLite Databases.

If you are not interesting in using SQLite Databases, you can still use these components, however certain features will not work as well
or be unavailable, as they are designed with SQLite in mind.

# Components

## Button
    <Button Variant="BUTTON_VARIANT.Primary" OnClick="OpenModalTwo">
        Open Modal 2
    </Button>

## Input
### String
    <Input 
        Variant="INPUT_VARIANT.Default" 
        Label="Name" 
        @bind-Value="newBankPayload.Name"
    />

## Dropdown
### String
    <Dropdown 
        Label="Is Active" 
        Options="@(["cool option", "lame option", "something between"])" 
        @bind-Value="myPayload.IsActive" 
    />

### Boolean
    <Dropdown 
        Label="Is Active" 
        Options="@(["true", "false"])" 
        @bind-Value="myPayload.IsActive" 
    />

## Form
### Whole
            <Form>
                <FormHeader>
                    <FormTitle>Bank Entity</FormTitle>
                    <FormDescription>The entity that manages your accounts</FormDescription>
                </FormHeader>
                <FormContent>
                    <FormRow>
                        <FormCell Ratio="1/2">
                            <Input Variant="INPUT_VARIANT.Default" Label="Name" @bind-Value="newBankPayload.Name"/>
                        </FormCell>
                        <FormCell Ratio="1/4">
                            <Dropdown Variant="DropdownVariant.Default" Label="Country" Options="@(["USA", "CAN", "MEX"])" @bind-Value="newBankPayload.Country" />
                        </FormCell>
                        <FormCell Ratio="1/4">
                            <Dropdown Variant="DropdownVariant.Default" Label="State" Options="@(["TN", "AK", "OR", "NY"])" @bind-Value="newBankPayload.State" />
                        </FormCell>
                    </FormRow>
                </FormContent>
                <FormFooter>
                    <FormSubmit Payload="newBankPayload" Variant="FORM_VARIANT.Add" />
                </FormFooter>
            </Form>
## Modal
### Closeable
    <Modal
        Title="Modal One"
        Size="md"
        Open="showModalOne"
        OnClose="CloseModal"
        HelpBtn="true"
        Variant="MODAL_VARIENT.AddEdit"
    >
        <div></div>
    </Modal>

## Card
googoogaagaa



# Pyre.Dev
This is simply the development front-end environment to help style and create components. It Imports Pyre.Element

# Pyre.Test
Similar to dev, except instead of importing Pyre.Element, it actually uses the packed package from that project, to test implementation.