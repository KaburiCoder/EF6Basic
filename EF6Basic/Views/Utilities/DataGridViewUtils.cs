namespace EF6Basic.Views.Utilities
{
  public static class DataGridViewUtils
  {
    public static void SetReadOnlySettings(this DataGridView dataGridView)
    {
      dataGridView.ReadOnly = true;
      dataGridView.AllowUserToAddRows = false;
      dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }
  }
}
