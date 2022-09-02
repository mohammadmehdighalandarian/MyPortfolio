using MyPortfolio.Models;

namespace MyPortfolio.Data
{
    public static class ProjectData
    {
        public static List<Project> GetAllProjects()
        {
            return new List<Project>()
            {
                new Project(1,"MyFirstShop","","Me","project-1.jpg"),
                new Project(2,"MyFirstShop","","Me","project-2.jpg"),
                new Project(3,"MyFirstShop","","Me","project-3.jpg"),
                new Project(4,"MyFirstShop","","Me","project-4.jpg")
            };
        }

        public static Project GetProjectBy(int id)
        {
            return GetAllProjects().Find(x => x.Id == id);
        }

    }
}
