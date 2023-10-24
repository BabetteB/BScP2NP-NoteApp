using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_project_Note_App_np.Models
{
    class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string Content { get; set; }
        public string Tag { get; set; } = "";


        private Color _color;
        public Color Color
        {
            get
            {
                if (_color == default(Color))
                {
                    // Generate a random color
                    Random random = new(Id);
                    _color = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
                }
                return _color;
            }
            set { _color = value; }
        }
    }
}
