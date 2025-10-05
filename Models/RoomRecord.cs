namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        public RoomRecord(string name, int roomId)
        {
            // Changes for Sprint # -- User Story -- Developer's Name
            // Changes Sprint 1, US-1A-3 -- As a message posting user, I want to create rooms for categorizing conversations. -- Zach Major
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        // Changes for Sprint # -- User Story -- Developer's Name
        // Changes Sprint 2, US-2D-2 -- As a system admin, I want to be able to set a limit to the number of users in any one room. -- Zach Major
        
        // Maximum number of users allowed in the room attribute
        public string Name
        {
            get;
            private set;
        }
    }
}
