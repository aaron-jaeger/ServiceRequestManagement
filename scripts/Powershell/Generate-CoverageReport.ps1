dotnet restore ./ServiceRequestManagement.sln
dotnet build ./ServiceRequestManagement.sln --configuration Release --no-restore
dotnet test ./tests/ServiceRequestManagement.UnitTests/ServiceRequestManagement.UnitTests.csproj --no-restore /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:Exclude="[*]ServiceRequestManagement.Infrastructure.*%2c[*]*Startup%2c[*]*Program%2c[*]ServiceRequestManagement.API.Controllers.*%2c[*]ServiceRequestManagement.API.Application.Behaviors.*"
reportgenerator "-reports:.\tests\ServiceRequestManagement.UnitTests\coverage.opencover.xml" "-targetdir:.\tests\ServiceRequestManagement.UnitTests\CoverageReports\" "-reporttypes:Html"
Start-Process .\tests\ServiceRequestManagement.UnitTests\CoverageReports\index.htm