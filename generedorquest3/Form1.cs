using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MissionDefiner
{
    public partial class Form1 : Form
    {
        private List<ItemRequirement> itemRequirements = new List<ItemRequirement>();

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            chkRequireLevel.CheckedChanged += (sender, e) =>
            {
                txtLevel.Enabled = chkRequireLevel.Checked;
                if (!chkRequireLevel.Checked)
                {
                    txtLevel.Clear();
                }
            };

            chkRequireExp.CheckedChanged += (sender, e) =>
            {
                txtExpAmount.Enabled = chkRequireExp.Checked;
                if (!chkRequireExp.Checked)
                {
                    txtExpAmount.Clear();
                }
            };

            chkRequireMoney.CheckedChanged += (sender, e) =>
            {
                txtMoneyAmount.Enabled = chkRequireMoney.Checked;
                if (!chkRequireMoney.Checked)
                {
                    txtMoneyAmount.Clear();
                }
            };

            chkRequirePrize.CheckedChanged += (sender, e) =>
            {
                bool enabled = chkRequirePrize.Checked;
                txtPrizeItemId.Enabled = enabled;
                txtPrizeItemQuantity.Enabled = enabled;
                txtPrizeItemQuality.Enabled = enabled;
                txtPrizeMoneyAmount.Enabled = enabled;

                if (!enabled)
                {
                    txtPrizeItemId.Clear();
                    txtPrizeItemQuantity.Clear();
                    txtPrizeItemQuality.Clear();
                    txtPrizeMoneyAmount.Clear();
                }
            };

            btnSaveMission.Click += new EventHandler(btnSaveMission_Click);

            btnAddItem.Click += (sender, e) =>
            {
                if (int.TryParse(txtItemId.Text, out int itemId) && int.TryParse(txtItemAmount.Text, out int itemAmount))
                {
                    AddItemToListView(itemId, itemAmount);

                    txtItemId.Clear();
                    txtItemAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID y una cantidad válidos.");
                }
            };

            btnIncreaseAmount.Click += (sender, e) =>
            {
                if (lvItems.SelectedItems.Count > 0)
                {
                    var selectedItem = lvItems.SelectedItems[0];
                    int index = lvItems.Items.IndexOf(selectedItem);
                    itemRequirements[index].Amount++;
                    selectedItem.SubItems[1].Text = itemRequirements[index].Amount.ToString();
                }
            };

            btnDecreaseAmount.Click += (sender, e) =>
            {
                if (lvItems.SelectedItems.Count > 0)
                {
                    var selectedItem = lvItems.SelectedItems[0];
                    int index = lvItems.Items.IndexOf(selectedItem);
                    if (itemRequirements[index].Amount > 1)
                    {
                        itemRequirements[index].Amount--;
                        selectedItem.SubItems[1].Text = itemRequirements[index].Amount.ToString();
                    }
                }
            };

            btnRemoveItem.Click += (sender, e) =>
            {
                if (lvItems.SelectedItems.Count > 0)
                {
                    var selectedItem = lvItems.SelectedItems[0];
                    int index = lvItems.Items.IndexOf(selectedItem);
                    itemRequirements.RemoveAt(index);
                    lvItems.Items.RemoveAt(index);
                }
            };

            btnMoveUp.Click += (sender, e) =>
            {
                if (lvItems.SelectedItems.Count > 0)
                {
                    var selectedItem = lvItems.SelectedItems[0];
                    int index = lvItems.Items.IndexOf(selectedItem);
                    if (index > 0)
                    {
                        SwapItems(index, index - 1);
                    }
                }
            };

            btnMoveDown.Click += (sender, e) =>
            {
                if (lvItems.SelectedItems.Count > 0)
                {
                    var selectedItem = lvItems.SelectedItems[0];
                    int index = lvItems.Items.IndexOf(selectedItem);
                    if (index < lvItems.Items.Count - 1)
                    {
                        SwapItems(index, index + 1);
                    }
                }
            };
        }

        private void AddItemToListView(int itemId, int itemAmount)
        {
            itemRequirements.Add(new ItemRequirement(itemId, itemAmount));

            ListViewItem item = new ListViewItem(itemId.ToString());
            item.SubItems.Add(itemAmount.ToString());
            lvItems.Items.Add(item);
        }

        private void SwapItems(int index1, int index2)
        {
            var temp = itemRequirements[index1];
            itemRequirements[index1] = itemRequirements[index2];
            itemRequirements[index2] = temp;

            var item1 = lvItems.Items[index1];
            var item2 = lvItems.Items[index2];

            lvItems.Items.RemoveAt(index2);
            lvItems.Items.Insert(index1, item2);
            lvItems.Items.RemoveAt(index1);
            lvItems.Items.Insert(index2, item1);
        }

        private void btnSaveMission_Click(object sender, EventArgs e)
        {
            string missionId = txtMissionId.Text;
            string missionName = txtMissionName.Text;
            bool requireLevel = chkRequireLevel.Checked;
            bool requireExp = chkRequireExp.Checked;
            bool requireMoney = chkRequireMoney.Checked;
            bool requirePrize = chkRequirePrize.Checked;
            string beginDialog = txtBeginDialog.Text;
            string resultDialog = txtResultDialog.Text;
            string helpText = txtHelpText.Text;

            // Validación de Misión
            if (string.IsNullOrWhiteSpace(missionId))
            {
                MessageBox.Show("Por favor, ingresa un ID de Misión.");
                return;
            }

            if (string.IsNullOrWhiteSpace(missionName))
            {
                MessageBox.Show("Por favor, ingresa un Nombre de Misión.");
                return;
            }

            if (requireLevel && (string.IsNullOrWhiteSpace(txtLevel.Text) || !int.TryParse(txtLevel.Text, out _)))
            {
                MessageBox.Show("Por favor, ingresa un nivel válido.");
                return;
            }

            int expAmount = 0;
            if (requireExp)
            {
                if (string.IsNullOrWhiteSpace(txtExpAmount.Text) || !int.TryParse(txtExpAmount.Text, out expAmount) || expAmount <= 0)
                {
                    MessageBox.Show("Por favor, ingresa una cantidad válida de experiencia.");
                    return;
                }
            }

            int moneyAmount = 0;
            if (requireMoney)
            {
                if (string.IsNullOrWhiteSpace(txtMoneyAmount.Text) || !int.TryParse(txtMoneyAmount.Text, out moneyAmount) || moneyAmount <= 0)
                {
                    MessageBox.Show("Por favor, ingresa una cantidad válida de dinero.");
                    return;
                }
            }

            int prizeItemId = 0;
            int prizeItemQuantity = 0;
            int prizeItemQuality = 0;
            int prizeMoneyAmount = 0;

            if (requirePrize)
            {
                if (!string.IsNullOrWhiteSpace(txtPrizeItemId.Text) && (!int.TryParse(txtPrizeItemId.Text, out prizeItemId) || prizeItemId <= 0))
                {
                    MessageBox.Show("Por favor, ingresa un ID de ítem válido.");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtPrizeItemQuantity.Text) && (!int.TryParse(txtPrizeItemQuantity.Text, out prizeItemQuantity) || prizeItemQuantity <= 0))
                {
                    MessageBox.Show("Por favor, ingresa una cantidad de ítem válida.");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtPrizeItemQuality.Text) && (!int.TryParse(txtPrizeItemQuality.Text, out prizeItemQuality) || prizeItemQuality < 0))
                {
                    MessageBox.Show("Por favor, ingresa una calidad de ítem válida.");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtPrizeMoneyAmount.Text) && (!int.TryParse(txtPrizeMoneyAmount.Text, out prizeMoneyAmount) || prizeMoneyAmount < 0))
                {
                    MessageBox.Show("Por favor, ingresa una cantidad de dinero válida para el premio.");
                    return;
                }
            }

            // Generar y Guardar Misión
            string missionContent = GenerateMissionContent(missionId, missionName, requireLevel, requireLevel ? int.Parse(txtLevel.Text) : 0, beginDialog, resultDialog, itemRequirements, requireExp, expAmount, requireMoney, moneyAmount, helpText, requirePrize, prizeItemId, prizeItemQuantity, prizeItemQuality, prizeMoneyAmount);

            SaveMissionToFile(missionContent);
        }

        private string GenerateMissionContent(string missionId, string missionName, bool requireLevel, int level, string beginDialog, string resultDialog, List<ItemRequirement> itemRequirements, bool requireExp, int expAmount, bool requireMoney, int moneyAmount, string helpText, bool requirePrize, int prizeItemId, int prizeItemQuantity, int prizeItemQuality, int prizeMoneyAmount)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DefineMission( {missionId} , \"{missionName}\" , {missionId} )");
            sb.AppendLine();
            sb.AppendLine($"MisBeginTalk( \"{beginDialog}\" )");
            sb.AppendLine($"MisBeginCondition(NoMission, {missionId} )");
            if (requireLevel)
            {
                sb.AppendLine($"MisBeginCondition(LvCheck, \">\" , {level} )");
            }
            sb.AppendLine($"MisBeginAction(AddMission,{missionId})");
            for (int i = 0; i < itemRequirements.Count; i++)
            {
                sb.AppendLine($"MisBeginAction(AddTrigger, {missionId}{i + 1} , TE_GETITEM, {itemRequirements[i].ItemId} , {itemRequirements[i].Amount} )");
            }
            sb.AppendLine($"MisCancelAction(ClearMission, {missionId})");
            sb.AppendLine();
            for (int i = 0; i < itemRequirements.Count; i++)
            {
                sb.AppendLine($"MisNeed(MIS_NEED_ITEM, {itemRequirements[i].ItemId} , {itemRequirements[i].Amount} , {10 * (i + 1)} , {itemRequirements[i].Amount} )");
            }
            sb.AppendLine();
            sb.AppendLine($"MisHelpTalk(\"{helpText}\")");
            sb.AppendLine($"MisResultTalk(\"{resultDialog}\")");
            for (int i = 0; i < itemRequirements.Count; i++)
            {
                sb.AppendLine($"MisResultCondition(HasItem, {itemRequirements[i].ItemId} , {itemRequirements[i].Amount} )");
            }
            for (int i = 0; i < itemRequirements.Count; i++)
            {
                sb.AppendLine($"MisResultAction(TakeItem, {itemRequirements[i].ItemId} , {itemRequirements[i].Amount} )");
            }
            if (requireExp)
            {
                sb.AppendLine($"MisResultAction(AddExp,{expAmount} , {expAmount} )");
            }
            if (requireMoney)
            {
                sb.AppendLine($"MisResultAction(AddMoney,{moneyAmount} , {moneyAmount} )");
            }
            sb.AppendLine($"MisResultAction(ClearMission, {missionId})");
            sb.AppendLine($"MisResultAction(SetRecord, {missionId})");
            if (requirePrize)
            {
                sb.AppendLine();
                sb.AppendLine($"MisResultBagNeed(0)");
                if (prizeItemId > 0 && prizeItemQuantity > 0)
                {
                    sb.AppendLine($"MisPrize(MIS_PRIZE_ITEM, {prizeItemId}, {prizeItemQuantity}, {prizeItemQuality})");
                }
                if (prizeMoneyAmount > 0)
                {
                    sb.AppendLine($"MisPrize(MIS_PRIZE_MONEY, {prizeMoneyAmount}, 1)");
                }
                sb.AppendLine($"MisPrizeSelAll(1)");
            }
            sb.AppendLine();
            for (int i = 0; i < itemRequirements.Count; i++)
            {
                sb.AppendLine($"InitTrigger()");
                sb.AppendLine($"TriggerCondition( 1, IsItem, {itemRequirements[i].ItemId} )");
                sb.AppendLine($"TriggerAction( 1, AddNextFlag, {missionId} , {10 * (i + 1)} , {itemRequirements[i].Amount} )");
                sb.AppendLine($"RegCurTrigger( {missionId}{i + 1} )");
            }

            return sb.ToString();
        }

        private void SaveMissionToFile(string missionContent)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"misión.txt"))
            {
                file.Write(missionContent);
            }

            MessageBox.Show("Misión guardada correctamente");
        }

        public class ItemRequirement
        {
            public int ItemId { get; set; }
            public int Amount { get; set; }

            public ItemRequirement(int itemId, int amount)
            {
                ItemId = itemId;
                Amount = amount;
            }
        }

        private void txtPrizeItemQuantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrizeItemQuality_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrizeItemId_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrizeMoneyAmount_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lblMissionId_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
