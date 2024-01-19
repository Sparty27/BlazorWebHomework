CREATE TRIGGER trg_Student
ON dbo.Students
AFTER DELETE, INSERT, UPDATE
AS
BEGIN
    DECLARE @numOfStudents INT;
    DECLARE @StudentGroupId INT;
    DECLARE @avgScoreOfStudents FLOAT;

    -- Get the affected StudentGroupId based on the operation
    IF EXISTS (SELECT 1 FROM INSERTED)
        SELECT @StudentGroupId = StudentGroupId FROM INSERTED;
    ELSE
        SELECT @StudentGroupId = StudentGroupId FROM DELETED;

    -- Update the number of students in the corresponding group
    SET @numOfStudents = (
        SELECT COUNT(*)
        FROM Students
        WHERE StudentGroupId = @StudentGroupId
    );

    SET @avgScoreOfStudents = ROUND((
        SELECT AVG(StudentAvgScore)
        FROM Students
        WHERE StudentGroupId = @StudentGroupId
    ), 2);

    UPDATE Groups
    SET GroupNumStudents = @numOfStudents,
        GroupAvgScore = @avgScoreOfStudents
    WHERE GroupId = @StudentGroupId;
END;
