namespace MINT_WebAPI.Constants
{
    public static class DatabaseConstants
    {
        #region Faculties
        public const string GetAllFacultiesWithDepartments = "sp_Faculties_GetAllFacultiesWithDepartments";
        public const string GetAllFaculties = "sp_Faculties_GetAllFaculties";
        public const string GetFaculties = "sp_Faculties_GetFaculties";
        public const string GetFacultyById = "sp_Faculties_GetFacultyById";
        public const string CreateFaculty = "sp_Faculties_CreateFaculty";
        public const string UpdateFaculty = "sp_Faculties_UpdateFaculty";
        public const string DeleteFaculty = "sp_Faculties_DeleteFaculty";
        #endregion

        #region Departments
        public const string GetAllDepartments = "sp_Departments_GetAllDepartments";
        #endregion

        #region Students
        public const string GetAllStudents = "sp_Students_GetAllStudents";
        public const string GetStudentById = "sp_Students_GetStudentById";
        public const string GetStudentViewModelById = "sp_Students_GetStudentViewModelById";
        public const string CreateStudent = "sp_Students_CreateStudent";
        public const string UpdateStudent = "sp_Students_UpdateStudent";
        public const string DeleteStudent = "sp_Students_DeleteStudent";
        #endregion

        #region Groups
        public const string GetAllGroups = "sp_Groups_GetAllGroups";
        #endregion
    }
}
