using Db;

namespace ManagerDb
{
    public partial class Form1 : Form
    {
        private DbContext _context;
        private string _tableName;
        private List<BaseEntity> _entities;

        public Form1()
        {
            InitializeComponent();
            _context = new DbContext();
        }

        private async void SelectButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == nameof(Db.User))
            {
                FillDataGridUser();
            }
            else if (SearchTextBox.Text == nameof(Cars))
            {
                FillDataGridCars();
            }
            else
            {
                MessageBox.Show($"Not found table {SearchTextBox.Text}");
                return;
            }

            _tableName = SearchTextBox.Text;
        }

        private async void FillDataGridUser()
        {
            var users = await _context.GetTable<Db.User>(nameof(Db.User));
            _entities = users.Select(_ => (BaseEntity)_).ToList();
            dataGridView1.DataSource = users;
        }

        private async void FillDataGridCars()
        {
            var cars = await _context.GetTable<Cars>(nameof(Cars));
            _entities = cars.Select(_ => (BaseEntity)_).ToList();
            dataGridView1.DataSource = cars;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_entities != null)
            {
                if (_tableName == nameof(User))
                {
                    List<User> list = _entities.Select(_ => (User)_).ToList();
                    list.Add(new User());
                    dataGridView1.DataSource = list;
                }
                else if (_tableName == nameof(Cars))
                {
                    List<Cars> list = _entities.Select(_ => (Cars)_).ToList();
                    list.Add(new Cars());
                    dataGridView1.DataSource = list;
                }
            }
        }

        private async void ChangeButton_Click(object sender, EventArgs e)
        {
            if(_entities != null && _entities.Count > 0)
            {
                if (_tableName == nameof(User))
                {
                    await _context.Insert<User>(_tableName, _entities.Last() as User);
                }
                else if (_tableName == nameof(Cars))
                {
                    await _context.Insert<Cars>(_tableName, _entities.Last() as Cars);
                }
            }
        }
    }
}
