   M S B A M L   `   `   `  ����F  BQuestionYou, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:QuestionYouQuestionYou  5   	       QuestionYou.AdminWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:QuestionYou     5   	     � Title$3  -Редактирование вопросов��5   	   $	��470��6)   $	��820��66   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��237* �6   �� 5      $
��563* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	Questions��5      $
��Left=�6&   $	��434��6A   $��Center=�6N   $	��557��6i   $��2��6u   $��22(�6�      Columns 5      5      �� 5   
   -   5         ��Name$ Create��5      $��Добавить��6!   $
��Left=�64   $��320,186,0,0q�6O   $	��Top=�6d   $	��243��6|   $��36��6�   $��20(�6�   $��1��6�   6�   �� 5   
   -   5        $ Delete��5      $��Удалить��6!   $
��Left=�63   $��320,227,0,0q�6N   $	��Top=�6c   $	��243��6{   $��36��6�   $��18(�6�   $��1��6�   6�   �� 5   
   -   5        $ Ok��5      $
��Ок��6   $
��Left=�6*   $��320,398,0,0q�6E   $	��Top=�6Z   $	��243��6r   $��36��6~   $��20(�6�   $��1��6�   6�   �� 5   
   -   5         ��Name$ QuestionTextBox��5      $
��Left=�6+   $	��135��6F   $��
320,46,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��243��6�   $��20(�6�   $��1��6�   �� 5   
   $��Ваш вопрос...��6   $��1��6(   $
��Left=�68   $��36��6S   $��
320,10,0,0q�6_   $	��Top=�6s   $	��243��6�   $��20(�6�   5      5      