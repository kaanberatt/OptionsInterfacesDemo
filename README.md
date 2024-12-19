# Options Pattern

The **Options Pattern** in ASP.NET Core helps you manage configuration settings from files like **appsettings.json** using strongly-typed classes. It makes settings easy to use and well-organized.

## Interfaces

The Options Pattern includes three main interfaces:

### IOptions
- Loads the settings once and keeps them the same throughout the application.
- Best for settings that do not change.

### IOptionsSnapshot
- Provides updated settings for each request in services with a scoped lifetime.
- Useful for reloadable settings.

### IOptionsMonitor
- Monitors settings at runtime and updates them when changes occur.
- Good for singleton services.

These interfaces make it easy to access the right and updated configuration in your application.
