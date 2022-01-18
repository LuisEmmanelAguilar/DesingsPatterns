﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.memento
{
    public class EditorState
    {
        private String content;

        public EditorState(String content)
        {
            this.content = content;
        }

        public String getContent()
        {
            return content;
        }

    }
}
