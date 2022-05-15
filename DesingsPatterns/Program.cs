
using DesingsPatterns.command.editor;
using DesingsPatterns.mediator;
using DesingsPatterns.observer;
using DesingsPatterns.observerExcercise;
using DesingsPatterns.templateExcercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mediator Pattern - Demo
            var dialog = new ArticlesDialogBox();
            dialog.simulateUserInteraction();
            Console.ReadLine();

        }
    }
}
