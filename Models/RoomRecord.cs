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

        public string Name
        {
            get;
            private set;
        }
    }
}
