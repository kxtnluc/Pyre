# Pyre

A Blazor Component Library, inspired by Shadcn design. It has been made specifically with the Hearth application in mind, and is a dependency in that project.

- [Components List](pyre-components.md)
- [Overview](#overview)
- [File Structure](#file-structure)
- [Global CSS](#global-css)
- [Component Layout](#component-layout)
- [Enums](#enums--computed-variables)
- [Syntax](#syntax)

## Overview

### File Structure

&ensp;**/Elements**

&emsp;This is the main folder of the library. It holds all of the main Components, like buttons and inputs etc.

&ensp;**/Enums**

&emsp;Holds generic, global enums used in many components, such as eStatus.cs with the E_STATUS enum.

&ensp;**/Icons**

&emsp;Holds all of the libraries Icon.razor files, and their variants.

---

### Global CSS

&ensp;**/wwwroot/css/token.css**

&emsp;This file contains the global css styling for the entire component library.
This mostly includes just color values, border radius values, font, and unset styling for the some of the base HTML elements.

---

### Component Layout

&ensp;**Sections**

&emsp;Each .razor component has 3 main sections.

1. **Razor Element**
   This is where the actual element is rendered, using all the info from the next two sections.

2. **Code Variables**
   These are split into 3 subbparts (Base, Pyre Base, Element Specific) 
   1. **Base**
   Handles Render Fragments, and very common variables in RCLs. 
   2. **Pyre Base**
   Similar to base, except stuff that is slightly more unsual and specific to my RCL and format. 
   3. **Element Specific**
   Just hyper-specific things that don't really fit into either category

3. **Computed Classes & Styles**
   This is where the component takes in info from the variables in section 2, and then creates a full computed class variable that is then rendered in the actual element.

4. **Logic Handling**
   This section is optional, and only exists on certain components like *Inputs*, *Buttons* and *Dropdowns*. Which is why it is optional

---

### Enums & Computed Variables

&ensp;All enums when implemented into the element itself are to be stored in "_exampleField" variables that convert the Enum to a String

---

### Syntax

&ensp;**CSS Classes**

&emsp;Classes that are conditional on any logic whatsoever, are spaced with two dashes: "--" Classes that are NOT conditional whatsoever, are soaced with two Underscores: "__" Example: "this--is--conditional" Example: "this__is__not__conditional"

---