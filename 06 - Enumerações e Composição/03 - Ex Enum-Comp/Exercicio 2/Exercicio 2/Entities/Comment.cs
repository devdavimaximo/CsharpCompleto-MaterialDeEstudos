using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Exercicio_2.Entities;

namespace Exercicio_2.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
