using Microsoft.AspNetCore.Builder;
using Acme.mianshiBookProject;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<mianshiBookProjectWebTestModule>();

public partial class Program
{
}
