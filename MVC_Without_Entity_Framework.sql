/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductID]
      ,[ProductName]
      ,[Price]
      ,[Count]
  FROM [MVC_Without_Entity_Framework].[dbo].[Product]