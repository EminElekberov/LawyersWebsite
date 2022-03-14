using LawyerbackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.ViewModel
{
    public class HomeVM
    {
        public List<Slider> sliders { get; set; }
        public List<OurAbout> ourAbouts { get; set; }
        public List<PictureSlider> pictureSliders { get; set; }
        public List<Holder> holders { get; set; }
        public List<Practise> practises { get; set; }
        public List<PracticeSlider> practiceSliders { get; set; }
        public List<IndexChoose> indexChooses { get; set; }
        public List<Teams> teams { get; set; }
        public List<Category> categories { get; set; }
        public List<News> news { get; set; }
        public List<Service> services { get; set; }
        public List<PageSlider> pageSliders { get; set; }
        public List<PageContact> pageContacts { get; set; }
        public List<PracticeAbout> practiceAbouts { get; set; }
        public List<AttorneysSlider> attorneysSliders { get; set; }
        public List<Biography> biographies { get; set; }
        public List<AttorneyWork> attorneyWorks { get; set; }
        public List<AttorneysLogo> attorneysLogos { get; set; }
        public List<BlogDetails> blogDetails { get; set; }
        public List<BlogHeader> blogHeaders { get; set; }
        public List<BlogIndexAbout> blogIndexAbouts { get; set; }
        public List<AllContactsAreas> allContacts { get; set; }
        public List<Contact> contacts { get; set; }
        public Contact  contact { get; set; }

    }
}
