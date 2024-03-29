﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the testRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.0")]
    [RepositoryFolder("bba19c84-5e6c-4c67-8e01-7d17a571d124")]
    public partial class testRepository : RepoGenBaseFolder
    {
        static testRepository instance = new testRepository();
        testRepositoryFolders.ExplorerAppFolder _explorer;
        testRepositoryFolders.Explorer1AppFolder _explorer1;
        testRepositoryFolders.Explorer2AppFolder _explorer2;
        testRepositoryFolders.DeleteMultipleItemsAppFolder _deletemultipleitems;
        testRepositoryFolders.RecycleBinAppFolder _recyclebin;

        /// <summary>
        /// Gets the singleton class instance representing the testRepository element repository.
        /// </summary>
        [RepositoryFolder("bba19c84-5e6c-4c67-8e01-7d17a571d124")]
        public static testRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public testRepository() 
            : base("testRepository", "/", null, 0, false, "bba19c84-5e6c-4c67-8e01-7d17a571d124", ".\\RepositoryImages\\testRepositorybba19c84.rximgres")
        {
            _explorer = new testRepositoryFolders.ExplorerAppFolder(this);
            _explorer1 = new testRepositoryFolders.Explorer1AppFolder(this);
            _explorer2 = new testRepositoryFolders.Explorer2AppFolder(this);
            _deletemultipleitems = new testRepositoryFolders.DeleteMultipleItemsAppFolder(this);
            _recyclebin = new testRepositoryFolders.RecycleBinAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("bba19c84-5e6c-4c67-8e01-7d17a571d124")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("22a873e5-d031-4758-b810-b53563cd425c")]
        public virtual testRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The Explorer1 folder.
        /// </summary>
        [RepositoryFolder("11ef1860-94ca-4d58-9050-e69b7362d693")]
        public virtual testRepositoryFolders.Explorer1AppFolder Explorer1
        {
            get { return _explorer1; }
        }

        /// <summary>
        /// The Explorer2 folder.
        /// </summary>
        [RepositoryFolder("c8f4b66f-88f8-4844-a864-36b0fa31d47a")]
        public virtual testRepositoryFolders.Explorer2AppFolder Explorer2
        {
            get { return _explorer2; }
        }

        /// <summary>
        /// The DeleteMultipleItems folder.
        /// </summary>
        [RepositoryFolder("9bc5ef36-f55e-4505-a305-7ba1e0ab4c09")]
        public virtual testRepositoryFolders.DeleteMultipleItemsAppFolder DeleteMultipleItems
        {
            get { return _deletemultipleitems; }
        }

        /// <summary>
        /// The RecycleBin folder.
        /// </summary>
        [RepositoryFolder("c6d283a2-6683-4545-a8be-0ea90003848b")]
        public virtual testRepositoryFolders.RecycleBinAppFolder RecycleBin
        {
            get { return _recyclebin; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.0")]
    public partial class testRepositoryFolders
    {
        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("22a873e5-d031-4758-b810-b53563cd425c")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            testRepositoryFolders.List11Folder _list11;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/desktop[@processname='explorer']", parentFolder, 30000, null, true, "22a873e5-d031-4758-b810-b53563cd425c", "")
            {
                _list11 = new testRepositoryFolders.List11Folder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("22a873e5-d031-4758-b810-b53563cd425c")]
            public virtual Ranorex.Desktop Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Desktop>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("22a873e5-d031-4758-b810-b53563cd425c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The List11 folder.
            /// </summary>
            [RepositoryFolder("c73206eb-fbed-4303-9448-f0bd8b12e1db")]
            public virtual testRepositoryFolders.List11Folder List11
            {
                get { return _list11; }
            }
        }

        /// <summary>
        /// The List11Folder folder.
        /// </summary>
        [RepositoryFolder("c73206eb-fbed-4303-9448-f0bd8b12e1db")]
        public partial class List11Folder : RepoGenBaseFolder
        {
            RepoItemInfo _list1Info;
            RepoItemInfo _newtextdocumentInfo;
            RepoItemInfo _recyclebinInfo;

            /// <summary>
            /// Creates a new List11  folder.
            /// </summary>
            public List11Folder(RepoGenBaseFolder parentFolder) :
                    base("List11", "?/?/list[@controlid='1']", parentFolder, 30000, null, false, "c73206eb-fbed-4303-9448-f0bd8b12e1db", "")
            {
                _list1Info = new RepoItemInfo(this, "List1", "", 30000, null, "4548ca8e-e64b-4b19-b5db-fe19e3061856");
                _newtextdocumentInfo = new RepoItemInfo(this, "NewTextDocument", "listitem[@text='New Text Document']", 30000, null, "b9d0b37a-d4da-4a81-8179-6f3b1bb2d184");
                _recyclebinInfo = new RepoItemInfo(this, "RecycleBin", "listitem[@text='Recycle Bin']", 30000, null, "b1a7d5ec-7b12-42be-b4c6-efd5c922f3ee");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c73206eb-fbed-4303-9448-f0bd8b12e1db")]
            public virtual Ranorex.List Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c73206eb-fbed-4303-9448-f0bd8b12e1db")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The List1 item.
            /// </summary>
            [RepositoryItem("4548ca8e-e64b-4b19-b5db-fe19e3061856")]
            public virtual Ranorex.List List1
            {
                get
                {
                    return _list1Info.CreateAdapter<Ranorex.List>(true);
                }
            }

            /// <summary>
            /// The List1 item info.
            /// </summary>
            [RepositoryItemInfo("4548ca8e-e64b-4b19-b5db-fe19e3061856")]
            public virtual RepoItemInfo List1Info
            {
                get
                {
                    return _list1Info;
                }
            }

            /// <summary>
            /// The NewTextDocument item.
            /// </summary>
            [RepositoryItem("b9d0b37a-d4da-4a81-8179-6f3b1bb2d184")]
            public virtual Ranorex.ListItem NewTextDocument
            {
                get
                {
                    return _newtextdocumentInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The NewTextDocument item info.
            /// </summary>
            [RepositoryItemInfo("b9d0b37a-d4da-4a81-8179-6f3b1bb2d184")]
            public virtual RepoItemInfo NewTextDocumentInfo
            {
                get
                {
                    return _newtextdocumentInfo;
                }
            }

            /// <summary>
            /// The RecycleBin item.
            /// </summary>
            [RepositoryItem("b1a7d5ec-7b12-42be-b4c6-efd5c922f3ee")]
            public virtual Ranorex.ListItem RecycleBin
            {
                get
                {
                    return _recyclebinInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The RecycleBin item info.
            /// </summary>
            [RepositoryItemInfo("b1a7d5ec-7b12-42be-b4c6-efd5c922f3ee")]
            public virtual RepoItemInfo RecycleBinInfo
            {
                get
                {
                    return _recyclebinInfo;
                }
            }
        }

        /// <summary>
        /// The Explorer1AppFolder folder.
        /// </summary>
        [RepositoryFolder("11ef1860-94ca-4d58-9050-e69b7362d693")]
        public partial class Explorer1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _menuitemnewInfo;
            RepoItemInfo _deleteInfo;
            RepoItemInfo _emptyrecyclebinInfo;

            /// <summary>
            /// Creates a new Explorer1  folder.
            /// </summary>
            public Explorer1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer1", "/contextmenu[@class='#32768' and @instance='0']", parentFolder, 30000, null, true, "11ef1860-94ca-4d58-9050-e69b7362d693", "")
            {
                _menuitemnewInfo = new RepoItemInfo(this, "MenuItemNew", "?/?/menuitem[@accessiblename='New']", 30000, null, "2ee89455-432c-41ce-829b-aeff1584b6f1");
                _deleteInfo = new RepoItemInfo(this, "Delete", "?/?/menuitem[@accessiblename='Delete']", 30000, null, "585ec276-b955-4fcc-acdf-70ed7ffa8bf4");
                _emptyrecyclebinInfo = new RepoItemInfo(this, "EmptyRecycleBin", "?/?/menuitem[@accessiblename='Empty Recycle Bin']", 30000, null, "4a746250-f7b5-44ea-a586-36c53ca7b482");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("11ef1860-94ca-4d58-9050-e69b7362d693")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("11ef1860-94ca-4d58-9050-e69b7362d693")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MenuItemNew item.
            /// </summary>
            [RepositoryItem("2ee89455-432c-41ce-829b-aeff1584b6f1")]
            public virtual Ranorex.MenuItem MenuItemNew
            {
                get
                {
                    return _menuitemnewInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItemNew item info.
            /// </summary>
            [RepositoryItemInfo("2ee89455-432c-41ce-829b-aeff1584b6f1")]
            public virtual RepoItemInfo MenuItemNewInfo
            {
                get
                {
                    return _menuitemnewInfo;
                }
            }

            /// <summary>
            /// The Delete item.
            /// </summary>
            [RepositoryItem("585ec276-b955-4fcc-acdf-70ed7ffa8bf4")]
            public virtual Ranorex.MenuItem Delete
            {
                get
                {
                    return _deleteInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Delete item info.
            /// </summary>
            [RepositoryItemInfo("585ec276-b955-4fcc-acdf-70ed7ffa8bf4")]
            public virtual RepoItemInfo DeleteInfo
            {
                get
                {
                    return _deleteInfo;
                }
            }

            /// <summary>
            /// The EmptyRecycleBin item.
            /// </summary>
            [RepositoryItem("4a746250-f7b5-44ea-a586-36c53ca7b482")]
            public virtual Ranorex.MenuItem EmptyRecycleBin
            {
                get
                {
                    return _emptyrecyclebinInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The EmptyRecycleBin item info.
            /// </summary>
            [RepositoryItemInfo("4a746250-f7b5-44ea-a586-36c53ca7b482")]
            public virtual RepoItemInfo EmptyRecycleBinInfo
            {
                get
                {
                    return _emptyrecyclebinInfo;
                }
            }
        }

        /// <summary>
        /// The Explorer2AppFolder folder.
        /// </summary>
        [RepositoryFolder("c8f4b66f-88f8-4844-a864-36b0fa31d47a")]
        public partial class Explorer2AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textdocumentInfo;

            /// <summary>
            /// Creates a new Explorer2  folder.
            /// </summary>
            public Explorer2AppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer2", "/contextmenu[@class='#32768' and @instance='1']", parentFolder, 30000, null, true, "c8f4b66f-88f8-4844-a864-36b0fa31d47a", "")
            {
                _textdocumentInfo = new RepoItemInfo(this, "TextDocument", "?/?/menuitem[@accessiblename='Text Document']", 30000, null, "9736d953-2154-4baa-9b32-3e532f21f097");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c8f4b66f-88f8-4844-a864-36b0fa31d47a")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c8f4b66f-88f8-4844-a864-36b0fa31d47a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TextDocument item.
            /// </summary>
            [RepositoryItem("9736d953-2154-4baa-9b32-3e532f21f097")]
            public virtual Ranorex.MenuItem TextDocument
            {
                get
                {
                    return _textdocumentInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The TextDocument item info.
            /// </summary>
            [RepositoryItemInfo("9736d953-2154-4baa-9b32-3e532f21f097")]
            public virtual RepoItemInfo TextDocumentInfo
            {
                get
                {
                    return _textdocumentInfo;
                }
            }
        }

        /// <summary>
        /// The DeleteMultipleItemsAppFolder folder.
        /// </summary>
        [RepositoryFolder("9bc5ef36-f55e-4505-a305-7ba1e0ab4c09")]
        public partial class DeleteMultipleItemsAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonyesInfo;

            /// <summary>
            /// Creates a new DeleteMultipleItems  folder.
            /// </summary>
            public DeleteMultipleItemsAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DeleteMultipleItems", "/form[@title='Delete Multiple Items']", parentFolder, 30000, null, true, "9bc5ef36-f55e-4505-a305-7ba1e0ab4c09", "")
            {
                _buttonyesInfo = new RepoItemInfo(this, "ButtonYes", "button[@text='&Yes']", 30000, null, "4cb77b9b-08a2-44ce-805a-7bc185637bf4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9bc5ef36-f55e-4505-a305-7ba1e0ab4c09")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9bc5ef36-f55e-4505-a305-7ba1e0ab4c09")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonYes item.
            /// </summary>
            [RepositoryItem("4cb77b9b-08a2-44ce-805a-7bc185637bf4")]
            public virtual Ranorex.Button ButtonYes
            {
                get
                {
                    return _buttonyesInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonYes item info.
            /// </summary>
            [RepositoryItemInfo("4cb77b9b-08a2-44ce-805a-7bc185637bf4")]
            public virtual RepoItemInfo ButtonYesInfo
            {
                get
                {
                    return _buttonyesInfo;
                }
            }
        }

        /// <summary>
        /// The RecycleBinAppFolder folder.
        /// </summary>
        [RepositoryFolder("c6d283a2-6683-4545-a8be-0ea90003848b")]
        public partial class RecycleBinAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _emptytextInfo;

            /// <summary>
            /// Creates a new RecycleBin  folder.
            /// </summary>
            public RecycleBinAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RecycleBin", "/form[@title='Recycle Bin']", parentFolder, 30000, null, true, "c6d283a2-6683-4545-a8be-0ea90003848b", "")
            {
                _emptytextInfo = new RepoItemInfo(this, "EmptyText", "element[@class='ShellTabWindowClass']//element[@instance='1']/container[@caption='ShellView']/?/?/text[@automationid='EmptyText']", 30000, null, "89bdf11f-ff94-40f8-ade0-86c09c45f452");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c6d283a2-6683-4545-a8be-0ea90003848b")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c6d283a2-6683-4545-a8be-0ea90003848b")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EmptyText item.
            /// </summary>
            [RepositoryItem("89bdf11f-ff94-40f8-ade0-86c09c45f452")]
            public virtual Ranorex.Text EmptyText
            {
                get
                {
                    return _emptytextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EmptyText item info.
            /// </summary>
            [RepositoryItemInfo("89bdf11f-ff94-40f8-ade0-86c09c45f452")]
            public virtual RepoItemInfo EmptyTextInfo
            {
                get
                {
                    return _emptytextInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}