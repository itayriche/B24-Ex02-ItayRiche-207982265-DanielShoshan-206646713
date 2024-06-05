using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace B24_Ex02_ItayRiche_207982265_DanielShoshan_206646713
{
    public class MemoryGameLogic
    {
        private GameBoard m_MemoryBoard;
        private ScoreTracker m_ScoreTracker;
        private eTypeOfGame m_TypeOfGame;
        private eCurrentPlayer m_CurrentPlayer;
        public const int k_MaxNumOfRowsOrColumns = 6;
        public const int k_MinNumOfRowsOrColumns = 4;

        public MemoryGameLogic(int i_NumberOfRows, int i_NumberOfColumns)
        {
            if (IsValidBoardSize(i_NumberOfRows, i_NumberOfColumns))
            {
                m_MemoryBoard = new GameBoard(i_NumberOfRows, i_NumberOfColumns);
                m_ScoreTracker = new ScoreTracker();

            }
        }

        public GameBoard MemoryBoard
        { 
            get
            { 
                return m_MemoryBoard;
            }
        }

        public ScoreTracker ScoreTracker
        {
            get
            {
                return m_ScoreTracker;
            }
        }

        public eTypeOfGame TypeOfGame
        {
            get
            {
                return m_TypeOfGame;
            }
            set
            {
                m_TypeOfGame = value;
            }
        }

        public eTypeOfGame CurrentPlayer
        {
            get
            {
                return (eTypeOfGame)m_CurrentPlayer;
            }
        }

        public static bool IsValidBoardSize(int i_NumberOfRows, int i_NumberOfColumns)
        {
            return ((i_NumberOfRows <= k_MaxNumOfRowsOrColumns) && (i_NumberOfRows >= k_MinNumOfRowsOrColumns) &&
                   (i_NumberOfColumns <= k_MaxNumOfRowsOrColumns) && (i_NumberOfColumns >= k_MinNumOfRowsOrColumns) &&
                   (i_NumberOfRows* i_NumberOfColumns % 2 == 0));
        }



    }
}
