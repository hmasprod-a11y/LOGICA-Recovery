// Legacy LOGICA contains a sibling namespace named Application.
// Resolve unqualified WinForms Application calls consistently across the recovered project.
global using Application = global::System.Windows.Forms.Application;
