using DesingsPatterns.memento;
using DesingsPatterns.mementoExcercise;
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
            //var editor = new Editor();
            //var history = new History();

            //editor.setContent("a");
            //history.push(editor.createState());

            //editor.setContent("b");
            //history.push(editor.createState());

            //editor.setContent("c");
            //editor.restore(history.pop());

            //editor.restore(history.pop());

            //Console.WriteLine(editor.getContent());
            //Console.ReadLine();

            var document = new DocumentMemento();
            var history = new HistoryDocument();

            document.setContent("Hello");
            history.push(document.createDocument());

            document.setFontName("Fon 9");
            history.push(document.createDocument());

            document.setFontSize(10);


            Console.WriteLine(document);



            document.restore(history.pop());
            Console.WriteLine(document);

            document.restore(history.pop());
            Console.WriteLine(document);

            Console.ReadLine();
        }
    }
}
