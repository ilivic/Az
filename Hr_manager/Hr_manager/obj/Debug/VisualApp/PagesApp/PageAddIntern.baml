   M S B A M L   `   `   `  ����E  AHr_manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Hr_manager.VisualApp.PagesAppHr_manager.VisualApp.PagesApp  5      1    +Hr_manager.VisualApp.PagesApp.PageAddIntern   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:Hr_manager.VisualApp.PagesApp     5      c _MaterialDesignThemes.MahApps, Version=3.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5        N� Title$  PageAddIntern��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��4* �6   �� 5      $��4* �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $��8* �6   �� 5      .+�5      �� -   5        $��45��5      $��45��6     �� CornerRadius$ 50��6,   ���	#FF234B6E � ToolTip$� �что бы узнать как работает необходимая функция, просто наведите на неё мышку :) что бы вернуться в меню нажми на меня��6r   ._�5      �� $��?��6   $��24(�6    $��Center=�6.   
�������6K   5      �� 5   
   -   5         ��Name$ SPIntr��5   2   $��1��6   $��1��6"   .+�5      �� -   5         ��Name$ CMBInter��5      ��5      �� 5       .R�5!      ��  �� Orientation$ 
Horizontal=�6%   .+�5"      �� $��50��6%   $��50��60   $ 50��6<   ��5#   "   �� 5$   &    �� ImageSource 61   �� *Photo+5&      �� 5'      ��6(   �� *
FullName+5(      5)      5+      �� 5,      -   5        	 ��Name$	 TxtFIO��5,   G   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 ФИО��6   $��10q�6;   ��6W   �� *
FullName+�� 5-      -   5        $��фото��5-      $��10q�6$   60   (  "System.Windows.Controls.DatePicker  5.      $
 дата приёма��6   $��10q�6F      SelectedDate 6R   �� *	DataStart+  5/      -   5          Name$ DPFin��5/   z   $#
 дата увольнения��6   $��10q�6J    6V   �� *
DataFinish+6z   �� 50      $��Действующий��6   {�.  $��10q�6?    d� 	IsChecked 6K   �� *
IsActive+51      �� 52   
   $��1��6   $��2��6"   .+�53      �� $1��+просмотреть статитсику��6   
��� ���$��10q�6H   $] Wдля просмотра статистики нужно выбрать стажера��6T   �� 54      -   5        $��Добавить��54      $��10q�6(   $� �Для добавления стажера необходимо указать только ФИО и выбрать фото, прочие поля будут заполнены автоматический��64   6�   �� 55      -   5        $ ��Редактировать��55      $��10q�6-   
����·�$� �Для редактирования стажера необходимо выбрать его из выпадающего списка и заполнить поля(фото можно выбрать через кнопку 'фото')��6N   6�   �� 56      -	   5        $��Уволить��56      $��10q�6'   $� �что бы уволить стажера необходимо выбрать из списка и нажать эту кнопку��6G   
���  ��6�   �� 57      -
   5        $-��'завершить стажировку��57      $��10q�6I   ���	#FF12B57D6U   �� 58      -   5        $
��Menu��58      6$   59      5:      5;      