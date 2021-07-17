# AspNetCore5.0
Using AspNetCore5.0. API core

.Core project is for domain/business layer (entities, domain services...)
.Application project is for application layer (DTOs, application services...)
.EntityFramework project is for EF Core integration (abstracts EF Core from other layers).
.Web project is for ASP.NET MVC layer.
.Tests project is for unit and integration tests (up to application layer, excluding web layer)
.Web.Tests project is for ASP.NET Core integrated tests (complete integration test including the web layer).