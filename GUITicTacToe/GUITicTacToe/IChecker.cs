using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITicTacToe
{
    public interface IChecker
    {
        void Accumulate(int i, string s);
        void Clear();
        bool Xwin();
        bool Owin();
        bool Tie();
    }
}
