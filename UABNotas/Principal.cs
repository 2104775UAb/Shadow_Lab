using System;

namespace UABNotas
{
    class UABNotas
    {
        [STAThread]
        static void Main() 
        {
            Controller controller = new Controller();
            controller.IniciarPrograma();
        }
    }
}
