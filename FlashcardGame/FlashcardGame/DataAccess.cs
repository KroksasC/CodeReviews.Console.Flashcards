﻿using System.Data;
using Dapper;

namespace FlashcardGame
{

    internal class DataAccess
    {
        public static List<Flashcard> GetFlashcards()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Dbtest")))
            {
                var output = connection.Query<Flashcard>($"select * from FlashcardTable").ToList();
                return output;
            }
        }
        public static List<Stack> GetStacks() 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Dbtest")))
            {
                var output = connection.Query<Stack>($"select * from StacksTable").ToList();
                return output;
            }
        }
        public static List<StudySession> GetStudySessions()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Dbtest")))
            {
                var output = connection.Query<StudySession>($"select * from StudySessionsTable").ToList();
                return output;
            }
        }

    } 
}
