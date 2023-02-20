using System;
using System.Collections.Generic;

namespace Introduction.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Group1 = new List<StudentViewModel>();
            Group2 = new List<StudentViewModel>();
        }

        public List<StudentViewModel> Group1 { get; set; }
        public List<StudentViewModel> Group2 { get; set; }

    }
}

