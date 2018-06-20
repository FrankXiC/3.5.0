using Abp.Application.Navigation;
using Abp.Localization;

namespace TESTABP.Web.Startup {
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class TESTABPNavigationProvider : NavigationProvider {
        public override void SetNavigation(INavigationProviderContext context) {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "Home/Index",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                new MenuItemDefinition(
                    "TaskList",
                    L("TaskList"),
                    url: "Tasks/TaskList",
                    icon: "fa fa-tasks"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Person,
                        L("Person"),
                        url: "People/PeopleList",
                        icon: "fa fa-tasks"
                    )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Course,
                        L("Course"),
                        url: "Courses/CourseList",
                        icon: "fa fa-tasks"
                    )
                );
        }

        private static ILocalizableString L(string name) {
            return new LocalizableString(name, TESTABPConsts.LocalizationSourceName);
        }
    }
}
