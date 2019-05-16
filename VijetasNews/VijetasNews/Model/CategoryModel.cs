using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VijetasNews.Model
{
    class CategoryModel
    {
       public string CategoryType { get; set; }
        public string UrlImage { get; set; }
        public string Description { get; set; }
        public  ObservableCollection<Model.NewsModel> NewsOnThis{get;set;}
    }
}
