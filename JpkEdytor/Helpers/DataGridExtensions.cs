namespace JpkEdytor.Helpers
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Input;

    /// <summary>
    /// A class providing useful extension for <see cref="DataGrid"/> control.
    /// </summary>
    public static class DataGridExtensions
    {
        #region AddCommand

        public static readonly DependencyProperty RegisterAddCommandProperty = DependencyProperty.RegisterAttached(
            "RegisterAddCommand",
            typeof(bool),
            typeof(DataGridExtensions),
            new PropertyMetadata(false, OnRegisterAddCommand));

        public static bool GetRegisterAddCommand(DependencyObject obj)
        {
            return (bool)obj.GetValue(RegisterAddCommandProperty);
        }
        public static void SetRegisterAddCommand(DependencyObject obj, bool value)
        {
            obj.SetValue(RegisterAddCommandProperty, value);
        }
        static void OnRegisterAddCommand(object sender, DependencyPropertyChangedEventArgs e)
        {
            var dataGrid = (DataGrid)sender;
            if (dataGrid == null) return;

            if ((bool)e.NewValue)
                dataGrid.CommandBindings.Add(new CommandBinding(AddCommand, AddCommandExecute, AddCommandCanExecute));
        }

        public static readonly RoutedUICommand AddCommand = new RoutedUICommand("AddCommand", "AddCommand", typeof(DataGridExtensions));
        static void AddCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            var dataGrid = (DataGrid)sender;
            if (dataGrid == null) return;

            var itemsSourceType = dataGrid.ItemsSource.GetType();
            var itemType = itemsSourceType.GetGenericArguments().Single();

            var items = dataGrid.ItemsSource as IList;
            items?.Add(Activator.CreateInstance(itemType));
        }
        static void AddCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (sender as DataGrid).CanUserAddRows;
        }

        #endregion

        #region DeleteCommand

        public static readonly DependencyProperty RegisterDeleteCommandProperty = DependencyProperty.RegisterAttached(
            "RegisterDeleteCommand",
            typeof(bool),
            typeof(DataGridExtensions),
            new PropertyMetadata(false, OnRegisterDeleteCommand));

        public static bool GetRegisterDeleteCommand(DependencyObject obj)
        {
            return (bool)obj.GetValue(RegisterDeleteCommandProperty);
        }
        public static void SetRegisterDeleteCommand(DependencyObject obj, bool value)
        {
            obj.SetValue(RegisterDeleteCommandProperty, value);
        }
        static void OnRegisterDeleteCommand(object sender, DependencyPropertyChangedEventArgs e)
        {
            var dataGrid = (DataGrid)sender;
            if (dataGrid == null) return;

            if ((bool)e.NewValue)
                dataGrid.CommandBindings.Add(new CommandBinding(DeleteCommand, DeleteCommandExecute, DeleteCommandCanExecute));
        }

        public static readonly RoutedUICommand DeleteCommand = new RoutedUICommand("DeleteCommand", "DeleteCommand", typeof(DataGridExtensions));
        static void DeleteCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            var dataGrid = (DataGrid)sender;
            if (dataGrid == null) return;

            var items = dataGrid.ItemsSource as IList;
            var item = dataGrid.CurrentItem;

            if(item != null)
                items?.Remove(item);
        }
        static void DeleteCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (sender as DataGrid).CanUserDeleteRows;
        }

        #endregion

        #region HeaderToolTipProperty

        public static readonly DependencyProperty HeaderToolTipProperty = DependencyProperty.RegisterAttached(
            "HeaderToolTip",
            typeof(string),
            typeof(DataGridColumn));

        public static string GetHeaderToolTip(DependencyObject dependencyObject)
        {
            return (string)dependencyObject.GetValue(HeaderToolTipProperty);
        }

        public static void SetHeaderToolTip(DependencyObject dependencyObject, string value)
        {
            dependencyObject.SetValue(HeaderToolTipProperty, value);

            var style = new Style(typeof(DataGridColumnHeader));

            if (!string.IsNullOrEmpty(value))
            {
                style.Setters.Add(new Setter(ToolTipService.ToolTipProperty, value));
                style.Setters.Add(new Setter(ToolTipService.ShowDurationProperty, 5000));
                style.Setters.Add(new Setter(ToolTipService.InitialShowDelayProperty, 500));
                style.Setters.Add(new Setter(ToolTipService.BetweenShowDelayProperty, 100));
            }

            var column = (DataGridColumn)dependencyObject;
            column.HeaderStyle = style;
        }

        #endregion
    }
}
