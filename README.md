# Ajay Employee Manager
ASP.NET Core MVC + SQLite employee CRUD demo. Includes dashboard, create/list/search/edit/delete employees. **No authentication yet. Use sample data only; do not expose publicly with real employee information.**

## Mobile GitHub Codespaces
1. Create a private GitHub repository. Upload all files and folders from this ZIP (including `.devcontainer`).
2. Open Code → Codespaces → Create codespace on main.
3. In its terminal run `dotnet run --urls http://0.0.0.0:5000`.
4. Open the forwarded port 5000 in the Ports tab. Keep port visibility Private.
5. SQLite database `employees.db` is created on first run.

Requires .NET 8 SDK. This is a starter demo, not production ready. Add proper admin authentication, authorization, migrations, backups, and security review before production deployment.
