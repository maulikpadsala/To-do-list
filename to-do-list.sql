USE [ProjectManagement]
GO
/****** Object:  Table [dbo].[tblToDo]    Script Date: 11/22/2021 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblToDo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Notes] [varchar](500) NULL,
	[Status] [int] NULL,
	[ModifyDate] [datetime] NULL,
	[EntryDate] [datetime] NULL,
 CONSTRAINT [PK_ToDotbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblToDo] ON
INSERT [dbo].[tblToDo] ([Id], [Notes], [Status], [ModifyDate], [EntryDate]) VALUES (1, N'Test', 0, CAST(0x0000ADE800000000 AS DateTime), CAST(0x0000ADE800000000 AS DateTime))
INSERT [dbo].[tblToDo] ([Id], [Notes], [Status], [ModifyDate], [EntryDate]) VALUES (2, N'Test1', 1, CAST(0x0000ADE700000000 AS DateTime), CAST(0x0000ADE700000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[tblToDo] OFF
/****** Object:  StoredProcedure [dbo].[spAdd]    Script Date: 11/22/2021 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spAdd]        
(        
    @Notes VARCHAR(500)      
)        
as         
Begin         
    Insert into tblToDo (Notes,ModifyDate,EntryDate)         
    Values (@Notes,null,getdate())         
End
GO
/****** Object:  StoredProcedure [dbo].[spDelete]    Script Date: 11/22/2021 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spDelete]         
(          
   @Id int          
)          
as           
begin          
   Delete from tblToDo where Id=@Id          
End
GO
/****** Object:  StoredProcedure [dbo].[spGetAll]    Script Date: 11/22/2021 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spGetAll]      
as      
Begin      
    select *      
    from tblToDO   
    order by Id 
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdate]    Script Date: 11/22/2021 15:57:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spUpdate]          
(          
    @Id INTEGER      
       
)          
as          
begin          
   Update tblToDo           
   set [Status]=1   
  ,[ModifyDate] = getdate()
   where Id=@Id          
End
GO
