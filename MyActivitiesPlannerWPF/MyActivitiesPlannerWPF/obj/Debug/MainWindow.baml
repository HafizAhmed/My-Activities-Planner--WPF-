   M S B A M L   `   `   `  ����  MyActivitiesPlannerWPF'    !MyActivitiesPlannerWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$  My Activities Planner 1.0��5   	   $��401.943��6+   $��547.261��6<   .��5      � .+�5   
   �� $
��Left=�6   $	��362��60   $	��Top=�6=   $	��529��6U   .@�5      �� $��Adding an Activity��6   $��-2,-2,-11,-5q�62   .��5	      � $��0,-1,0,1q�6   .+�5
      �� $��Choose a Date��6   $��10,10,399,253q�64   $
��Bold"�6K   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dateTimePicker1��5   !   $
��Left=�6:   $��3,40,0,0q�6U   $	��Top=�6g   $	��129��6   �� 5      $��Activity��6   $��10,80,430,175q�6/   $
��Bold"�6F   �� 5      -   5         ��Name$ 
ActivityTB��5       �� TextWrapping$
 Wrap=�62   $��10,113,294,185q�6G   �� 5      $��
Start Time��6   $��10,196,441,110q�61   $
��Bold"�6I   �� 5      -   5        $ StartTimeTB��5      $
 Wrap=�63   $��86,195,319,108q�6H    J� RenderTransformOrigin$ 0.5,0.5&�6`   �� 5      $��End Time��6   $��209,196,220,110q�6/   $
��Bold"�6H   �� 5      -   5        $ 	EndTimeTB��5      $
 Wrap=�61   $��284,196,105,110q�6F   $ 0.5,0.5&�6_   �� 5      -   5         ��Name$ SubmitButton1��5      $��Submit��64   $
��Left=�6E   $��
14,268,0,0q�6`   $	��Top=�6t   $��75��6�   6�   5      5      �� 5      $��Displaying Activities��6   $��10,0,-14,-3q�65   .��5      � ���	#FFE5E5E5$��0,-15,0,-100q�6.   .+�5       �� $��Choose a Date��6   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6b   $	��113��6z   $��2��6�     5!      -   5        $ dateTimePicker2��5!   !   $
��Left=�6:   $��	61,41,0,0q�6U   $	��Top=�6h     5"      -   5        $ dateTimePicker3��5"   !   $
��Left=�6:   $��
245,41,0,0q�6U   $	��Top=�6i   �� 5#      $
��FROM��6   $
��Left=�6+   $��	18,40,0,0q�6F   $	��Top=�6Y   $
��Bold"�6q   �� 5$      $��TO��6   $
��Left=�6)   $��
187,40,0,0q�6D   $	��Top=�6X   $
��Bold"�6p   &   System.Windows.Controls.DataGrid  5%      -   5          Name$ DataGrid��5%      $
��Left=�6I   $��
18,132,0,0q�6d   $	��Top=�6x   $	��153��6�   $	��443��6�   ��61   �� 6�   �� 5&      -	   5        $ 
ShowButton��5&      $
��Show��61   $
��Left=�6@   $��	18,89,0,0q�6[   $	��Top=�6n   $��75��6�   6�   �� 5'      -
   5        $ SubmitChangesButton��5'      $��Submit Changes��6:   $
��Left=�6S   $��
18,302,0,0q�6n   $	��Top=�6�   $	��105��6�   6�   5)      5*      5+      5-      5.      