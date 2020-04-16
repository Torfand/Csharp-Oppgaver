using System;
using System.Collections.Generic;
using System.Text;

namespace Tre_På_Rad
{

    class Combo
    {
        private readonly int _index1;
        private readonly int _index2;
        private readonly int _index3;
        private readonly CellContent[] _cells;

        public Combo(CellContent[] cells, int index1, int index2, int index3) =>
            (_cells, _index3, _index2, _index1) = (cells, index3, index2, index1);
       

        public CellContent IsWinning()
        {
            if (_cells[_index1] == _cells[_index2]
                && _cells[_index1] == _cells[_index3])
            {
                return _cells[_index1];
            }
            return CellContent.None;
        }
    }
}
