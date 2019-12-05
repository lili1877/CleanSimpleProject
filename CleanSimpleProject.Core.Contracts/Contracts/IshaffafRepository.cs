using CleanSimpleProject.Core.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace shaffaf.Models
{
    public interface IshaffafRepository
    {
        IEnumerable<StaticPage> GetAllStaticPages();
        int countStaticPages();
        StaticPage GetStPageById(int id);
        void delStaticPages(StaticPage sp1);
        void  AddEditStaticPages(StaticPage sp1);

        IEnumerable<Project> GetAllProjects();
        int countProject();
        Project GetProjectById(int id);
        void delProject(Project p1);
        void AddEditProject(Project p1);
        IEnumerable<ProjectPic> GetAllPics(int ProjectId);
        IEnumerable<ProjectPic> GetAllPicsByType(int projectId,byte type);
        
        int countProjectPic(int projectId);
        ProjectPic GetProjectPicById(int id);
        void delProjectPic(ProjectPic pic1);
        void AddEditProjectPic(ProjectPic pic1);

        IEnumerable<Offer> GetAllOffers();
        int countOffer();
        Offer GetOfferById(int id);
        void delOffer(Offer o1);
        void AddEditOffers(Offer o1);


        IEnumerable<IdeaItem> GetAllIdeas();
        IdeaMain GetIdeamainById(int id);
        Task<bool>  SaveChangesAsync();
    }
}