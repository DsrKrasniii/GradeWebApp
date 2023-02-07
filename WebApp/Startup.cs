using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            // app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blah}/{action=Index}/{id?}"
                );
            });
        }
    }
/*Mission #4 Assignment
Build an ASP.NET Web App using the same structure as in the "Building First Web App" series
of videos. (i.e. Non-MVC for now).
(RECOMMENDATION: Do your best to NOT just follow along step-by-step to complete
the assignment. Rather, try to study and learn the principles as you follow along with the
videos. Then try to complete the requirements on your own, referring back to your notes,
your practice program, and the videos as necessary as you get stuck.)
Include:
• A webpage title *
• Header that lists your preferred name *
• A picture of yourself doing something you enjoy *
• A paragraph on what you hope to get out of this IS 413 class *
• A list of the Top #3 jobs you are most interested in pursuing when you graduate *
• A "Grade Calculator" form that takes as input a percentage scored for each grade
category listed in the syllabus
• An icon for the website (displayed on the tab next to the website title)
(#notcoveredinthevideos)
• Style the site using Bootstrap.
• Include at least one change to the styling using your own CSS file.
Build a JavaScript program that calculates and displays both a final percentage and a letter grade
using the "Grade Calculator" form entries based on the weights listed in the syllabus. Use
jQuery selectors (i.e. the “$”) in your program.Print the letter grade to the form (not in an alert.)
Write good code (use good indentation, commenting, whitespace, descriptive variable names,
etc.) Good style counts for 10% of the score on each assignment.
Submit a link to the GitHub repository containing your project via Learning Suite.
*/
}