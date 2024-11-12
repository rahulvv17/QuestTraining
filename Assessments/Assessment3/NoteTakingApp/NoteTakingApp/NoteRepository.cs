using log4net;
using NoteTakingApp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

public class NoteRepository
{
    private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private readonly string _connectionString;

    public NoteRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Create(Note note)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Notes (Title, Content, CreatedAt) VALUES (@Title, @Content, @CreatedAt)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);

                connection.Open();
                command.ExecuteNonQuery();
                log.Info("Note created successfully.");
            }
        }
        catch (Exception ex)
        {
            log.Error("Failed to create note", ex);
            throw new ApplicationException("An error occurred while creating the note.");
        }
    }

    public List<Note> GetAll()
    {
        var notes = new List<Note>();
        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Notes";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notes.Add(new Note
                        {
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            Content = (string)reader["Content"],
                            CreatedAt = (DateTime)reader["CreatedAt"],
                            UpdatedAt = reader["UpdatedAt"] as DateTime?
                        });
                    }
                }
                log.Info("Fetched all notes successfully.");
            }
        }
        catch (Exception ex)
        {
            log.Error("Failed to fetch notes", ex);
            throw new ApplicationException("An error occurred while fetching notes.");
        }
        return notes;
    }

    public void Update(Note note)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Notes SET Title = @Title, Content = @Content, UpdatedAt = @UpdatedAt WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);
                command.Parameters.AddWithValue("@Id", note.Id);

                connection.Open();
                command.ExecuteNonQuery();
                log.Info("Note updated successfully.");
            }
        }
        catch (Exception ex)
        {
            log.Error("Failed to update note", ex);
            throw new ApplicationException("An error occurred while updating the note.");
        }
    }

    public void Delete(int noteId)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Notes WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", noteId);

                connection.Open();
                command.ExecuteNonQuery();
                log.Info("Note deleted successfully.");
            }
        }
        catch (Exception ex)
        {
            log.Error("Failed to delete note", ex);
            throw new ApplicationException("An error occurred while deleting the note.");
        }
    }
}
