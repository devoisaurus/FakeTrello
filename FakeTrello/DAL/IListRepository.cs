using FakeTrello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeTrello.DAL
{
    interface IListRepository
    {
        //create methods
        void AddList(string name, Board board);
        void AddList(string name, int boardId);

        //get methods
        List GetList(int listId);
        List<List> GetListsFromBoard(int boardId); // List of Trello Lists

        //delete methods
        bool RemoveList(int listId);
    }
}
