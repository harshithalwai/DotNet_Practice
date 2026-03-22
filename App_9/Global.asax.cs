using System;

namespace App_9
{
    public class Global : System.Web.HttpApplication
    {

        //void Application_Start(object sender, EventArgs e)
        //{
        //    // Code that runs on application startup
        //}

        void Application_End(object sender, EventArgs e)
        {
            // Code that runs on application shutdown
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
        }

        //void Session_Start(object sender, EventArgs e)
        //{
        //    // Code that runs when a new session is started
        //}

        //void Session_End(object sender, EventArgs e)
        //{
        //    // Code that runs when a session ends.
        //    // Note: The Session_End event is raised only when 
        //    // sessionstate mode is set to InProc in Web.config.
        //}



        void Application_Start(object sender, EventArgs e)
        {

            // Create Application state variables
            Application["TotalApplications"] = 0;
            Application["TotalUserSessions"] = 0;
            // Increment TotalApplications by 1
            Application["TotalApplications"] = (int)Application["TotalApplications"] + 1;
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Increment TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            // Decrement TotalUserSessions by 1
            Application["TotalUserSessions"] = (int)Application["TotalUserSessions"] - 1;
        }

    }
}