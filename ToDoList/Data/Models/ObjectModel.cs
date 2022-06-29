namespace ToDoList.Data.Models
{
    public class ObjectModel
    {
        public string? Name { get; set; }
        public int SecurityProfileID { get; set; }
        public int PermissionStatus { get; set; }
        public int PermissionID { get; set; }
        public int StatusBits { get; set; }
        //4611686018427387903 = Disabled
    }
}
