﻿using System;
using Woop.Xamarin.Navigaton.DependencyInjection;
using Xamarin.Forms;

namespace Woop.Xamarin.Navigaton
{
    public interface INavigation
    {
        /// <summary>
        /// Initializes the navigation. If INavigation.SetMainPage{T}() was not called it sets 
        /// the Application.MainPage to first Page that was Registerd otherwise the MainPage is set to the given MainPage.
        /// Additionaly it will load an alternativ StarPage if INavigation.SetStartPage{T} is called. This is usefull
        /// if the MainPage is a MasterDetailPage, because it will load the StartPage into the Detail Part of the MasterDetailPage
        /// </summary>
        /// <param name="formsApplication"></param>
        void Init(Application formsApplication);

        /// <summary>
        /// Sets the main page if you don't want the first page that got registered to be the MainPage.
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        void SetMainPage<TPage>() where TPage : class;

        /// <summary>
        ///// Sets an alternativ StartPage. Usefull if the MainPage is a MasterDetailPage, because it will load the StartPage
        ///// into the Detail Part of the MasterDetailPage.
        ///// </summary>
        ///// <typeparam name="TPage"></typeparam>
        //void SetStartPage<TPage>() where TPage : class;

        /// <summary>
        /// Pops all pages and shows the MainPage
        /// </summary>
        void ToMainPage();

        /// <summary>
        /// Navigates to the Page given as the {T] Parameter. If the MainPage is a MasterDetailPage, it loads the Page
        /// into the Detail Part of the MasterDetailPage.
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        void NavigateTo<TPage>() where TPage : class;
        void NavigateTo(Type pageType);

        /// <summary>
        /// Register a Page and the corresponding Viewmodel.
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <typeparam name="TViewModel"></typeparam>

        void RegisterPage<TPage, TViewModel>() where TPage : class where TViewModel : class;

        /// <summary>
        /// Only Register the page, because there is no Viewmodel at the moment :)
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        void RegisterPage<TPage>();

        void RegisterMasterDetailPage<TMasterDetailPage, TMaster, TDetail>();
    }
}
