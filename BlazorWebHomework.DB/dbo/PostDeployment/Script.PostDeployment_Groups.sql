IF NOT EXISTS (SELECT * FROM [Groups])
BEGIN
	SET IDENTITY_INSERT [dbo].[Groups] ON;
	INSERT INTO Groups (GroupId, GroupName, GroupFacultyId, GroupNumStudents, GroupAvgScore) VALUES 
		(1,N'ФКіС-21',1,NULL,NULL),
		(2,N'ФКіС-22',1,NULL,NULL),
		(3,N'ФК-21',1,NULL,NULL),
		(4,N'ФК-31',1,NULL,NULL),
		(5,N'ФК-41',1,NULL,NULL),

		(6,N'ЕОС-21',2,NULL,NULL),
		(7,N'АГ-21',2,NULL,NULL),
		(8,N'АІ-21',2,NULL,NULL),
		(9,N'ЛГ-21',2,NULL,NULL),

		(10,N'ГРС-21',3,NULL,NULL),
		(11,N'ХТ-21',3,NULL,NULL),
		(12,N'ХТ-31',3,NULL,NULL),
		(13,N'ТЛП-31',3,NULL,NULL),
		(14,N'ХТ-41',3,NULL,NULL),

		(15,N'ІМ-21',4,NULL,NULL),
		(16,N'М-21',4,NULL,NULL),
		(17,N'М-31',4,NULL,NULL),
		(18,N'АТ-31',4,NULL,NULL),

		(19,N'ІПЗ-21',5,NULL,NULL),
		(20,N'ІПЗ-22',5,NULL,NULL),
		(21,N'ІПЗ-23',5,NULL,NULL),
		(22,N'ІПЗ-24',5,NULL,NULL),
		(23,N'КН-21',5,NULL,NULL),

		(24,N'МОм-11',6,NULL,NULL),
		(25,N'МКм-11',6,NULL,NULL),
		(26,N'ЕКм-21',6,NULL,NULL),
		(27,N'ОПм-21',6,NULL,NULL),
		(28,N'ФБСм-21',6,NULL,NULL),
		(29,N'ПУАм-21',6,NULL,NULL),
		(30,N'МО-31',6,NULL,NULL),
		(31,N'ПР-31',6,NULL,NULL),

		(32,N'Д-21',7,NULL,NULL),
		(33,N'Д-22',7,NULL,NULL),
		(34,N'Д-23',7,NULL,NULL),
		(35,N'Д-24',7,NULL,NULL);
	SET IDENTITY_INSERT [dbo].[Groups] OFF;
END