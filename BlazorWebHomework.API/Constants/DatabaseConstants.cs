namespace MINT_WebAPI.Constants
{
    public static class DatabaseConstants
    {
        #region Faculties
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
    }
}
