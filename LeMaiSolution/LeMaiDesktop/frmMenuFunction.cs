using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Linq;
using Common;
using LeMaiDomain;
using LeMaiLogic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace LeMaiDesktop
{
    //Int32.Parse(txtma.Text, System.Globalization.NumberStyles.AllowThousands)
    //double.Parse(txtma.Text,CultureInfo.CurrentCulture)
    //decimal.Parse(txtma.Text,CultureInfo.CurrentCulture);
    public partial class frmMenuFunction : frmBase
    {
        private int status = 0;//0: Không làm gì cả, 1: Chế độ thêm mới, 2: Chế độ chỉnh sửa
        private MenuFunction Gitem;
        string safeName = string.Empty;

        public frmMenuFunction() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        {
            InitializeComponent();
            gridMain.AutoGenerateColumns = false;
            this.gridMain.RowTemplate.MinimumHeight = 22;
            Separator();
        }

        private void frmMenuFunction_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableButton(status);

        }

        #region Xử lý phím tắt

        // Xử lý phím tắt trên form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return true;
            }
            if (keyData == (Keys.Control | Keys.Q))
            {
                btnClose_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Enable hoặc Disable các button chức năng Trạng thái đang hoạt động 0: Không làm gì cả, 1: Thêm mới, 2: Sửa
        private void EnableButton(int stus)
        {
            //Enable tất cả các button
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            if (stus == 0)
            {
                btnSave.Enabled = false;
                btnNew.Text = "&Mới";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iNew;
                txtTitle.Enabled = false;
                txtControllerName.Enabled = false;
                txtAcctionName.Enabled = false;
                txtControllerNameApi.Enabled = false;
                txtAcctionNameApi.Enabled = false;
                txtRouteId.Enabled = false;
                chbIsMenu.Enabled = false;
                chbIsPublic.Enabled = false;
                txtIcon.Enabled = false;
                txtCssClass.Enabled = false;
                txtParrent.Enabled = false;
                txtSortIndex.Enabled = false;
                txtNote.Enabled = false;
                cmbNhomRibbonBar.Enabled = false;
                cmbParent.Enabled = false;
                txtMenuWidth.Enabled = false;
                txtMenuImageName.Enabled = false;
                cmbShowType.Enabled = false;
            }
            if (stus == 1)
            {
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtTitle.Enabled = true;
                txtControllerName.Enabled = true;
                txtAcctionName.Enabled = true;
                txtControllerNameApi.Enabled = true;
                txtAcctionNameApi.Enabled = true;
                txtRouteId.Enabled = true;
                chbIsMenu.Enabled = true;
                chbIsPublic.Enabled = true;
                txtIcon.Enabled = true;
                txtCssClass.Enabled = true;
                txtParrent.Enabled = true;
                txtSortIndex.Enabled = true;
                txtNote.Enabled = true;
                cmbNhomRibbonBar.Enabled = true;
                cmbParent.Enabled = true;
                txtMenuWidth.Enabled = true;
                txtMenuImageName.Enabled = true;
                cmbShowType.Enabled = true;
            }
            if (stus == 2)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNew.Enabled = true;
                btnNew.Text = "&Bỏ qua";
                btnNew.Image = global::LeMaiDesktop.Properties.Resources.iUndo;
                txtTitle.Enabled = true;
                txtControllerName.Enabled = true;
                txtAcctionName.Enabled = true;
                txtControllerNameApi.Enabled = true;
                txtAcctionNameApi.Enabled = true;
                txtRouteId.Enabled = true;
                chbIsMenu.Enabled = true;
                chbIsPublic.Enabled = true;
                txtIcon.Enabled = true;
                txtCssClass.Enabled = true;
                txtParrent.Enabled = true;
                txtSortIndex.Enabled = true;
                txtNote.Enabled = true;
                cmbNhomRibbonBar.Enabled = true;
                cmbParent.Enabled = true;
                txtMenuWidth.Enabled = true;
                txtMenuImageName.Enabled = true;
                cmbShowType.Enabled = true;
            }
        }
        // Xóa trắng tất cả các textbox.
        private void ClearText()
        {
            txtTitle.Text = string.Empty;
            txtControllerName.Text = string.Empty;
            txtAcctionName.Text = string.Empty;
            txtControllerNameApi.Text = string.Empty;
            txtAcctionNameApi.Text = string.Empty;
            txtRouteId.Text = string.Empty;
            txtIcon.Text = string.Empty;
            txtCssClass.Text = string.Empty;
            txtParrent.Text = string.Empty;
            txtSortIndex.Text = string.Empty;
            txtNote.Text = string.Empty;
            txtMenuWidth.Text = "80";
            txtMenuImageName.Text = string.Empty;
            cmbShowType.SelectedIndex = 0;
        }

        // Fill dữ liệu vào các control.
        private void FillData(MenuFunction item, bool copy)
        {
            txtTitle.Text = item.Title;
            txtControllerName.Text = item.ControllerName;
            txtAcctionName.Text = item.AcctionName;
            txtControllerNameApi.Text = item.ControllerNameApi;
            txtAcctionNameApi.Text = item.AcctionNameApi;
            txtRouteId.Text = item.RouteId;
            chbIsMenu.Checked = item.IsMenu;
            chbIsPublic.Checked = item.IsPublic;
            txtIcon.Text = item.Icon;
            txtCssClass.Text = item.CssClass;
            txtParrent.Text = item.Parrent;
            txtSortIndex.Text = item.SortIndex.ToString();
            txtNote.Text = item.Note;
            cmbProjectUsed.SelectedIndex = item.ProjectUsed;
            if (item.MenuWidth != null)
            {
                txtMenuWidth.Text = item.MenuWidth.ToString();
            }
            txtMenuImageName.Text = item.MenuImageName;
            if (item.FormShowType != null)
            {
                cmbShowType.SelectedIndex = (int)item.FormShowType;
            }
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                MenuFunctionGroup subparents = dc.MEnufunctiongroup.GetObjectCon(PBean.SCHEMA,
                          "where Id = @id",
                               "@id", item.FK_MenuGroup);

                cmbParent.DataSource = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup IS NULL OR FK_MenuGroup='' ");
                cmbParent.DisplayMember = "GroupName";
                cmbParent.ValueMember = "Id";
                cmbParent.SelectedValue = subparents.FK_MenuGroup;


                cmbNhomRibbonBar.DataSource = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup = @id_parent",
                 "@id_parent", cmbParent.SelectedValue.ToString());
                cmbNhomRibbonBar.DisplayMember = "GroupName";
                cmbNhomRibbonBar.ValueMember = "Id";
                cmbNhomRibbonBar.SelectedValue = item.FK_MenuGroup;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            finally
            {
                dc.Close();
            }
        }

        #region Xử lý TextBox tìm kiếm dữ liệu trên form
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_MenuFunction] where ControllerName like N'%" + txtSearch.Text + "%' OR Title LIKE N'%" + txtSearch.Text + "%' OR AcctionName LIKE N'%" + txtSearch.Text + "%'");
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
            finally
            {
                dc.Close();
            }
        }
        #endregion

        #endregion

        #region Xử lý sự kiện cho các button - GridControl
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtControllerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAcctionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtControllerNameApi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtAcctionNameApi_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtRouteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtIcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCssClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtParrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtStatus_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void dtpCreateDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtSortIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtSortIndex_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtProjectUsed_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtProjectUsed_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtFK_MenuGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtMenuWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtMenuWidth_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }
        private void txtMenuImageName_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFK_MenuImage_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtCreateUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtUpdateUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Control_KeyPress(sender, e);
        }
        private void txtFormShowType_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.Number_KeyPress(sender, e);
        }
        private void txtFormShowType_KeyUp(object sender, KeyEventArgs e)
        {
            base.Number_KeyUp(sender, e);
        }

        // Load data từ database lên lưới
        private void LoadData()
        {
            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                gridMain.DataSource = dc.GetData("select * from " + PBean.SCHEMA + ".[view_MenuFunction] order by SortIndex asc");

                cmbParent.DataSource = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup IS NULL OR FK_MenuGroup=''");
                cmbParent.DisplayMember = "GroupName";
                cmbParent.ValueMember = "Id";

                cmbNhomRibbonBar.DataSource = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup=@FK_MenuGroup",
                     "@FK_MenuGroup", cmbParent.SelectedValue.ToString());
                cmbNhomRibbonBar.DisplayMember = "GroupName";
                cmbNhomRibbonBar.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
            finally
            {
                dc.Close();

            }
        }

        private void gridMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status != 1)
            {
                btnEdit_Click(null, null);
            }
            else
            {
                try
                {
                    int index = gridMain.SelectedRows[0].Index;
                    IDataContext dc = PCommon.getDataContext();
                    try
                    {
                        dc.Open();
                        Gitem = dc.MEnufunction.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                        if (null != Gitem)
                        {
                            FillData(Gitem, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error(ex);
                        MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                    }
                    finally
                    {
                        dc.Close();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    return;
                }
            }
        }
        //Thêm mới
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (status != 0)
            {
                status = 0;
                EnableButton(status);
            }
            else
            {
                status = 1;
                EnableButton(status);
                ClearText();
                txtTitle.Focus();
            }
        }

        //Chỉnh sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                int index = gridMain.SelectedRows[0].Index;
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    dc.Open();
                    Gitem = dc.MEnufunction.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                    if (null != Gitem)
                    {
                        FillData(Gitem, false);
                        status = 2;
                        EnableButton(status);
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                }
                finally
                {
                    dc.Close();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //Lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtControllerName.Text))
            {
                MessageBox.Show("ControllerName không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtControllerName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtAcctionName.Text))
            {
                MessageBox.Show("AcctionName không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAcctionName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtSortIndex.Text))
            {
                MessageBox.Show("SortIndex không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSortIndex.Focus();
                return;
            }
            if (cmbProjectUsed.SelectedIndex < 0)
            {
                MessageBox.Show("ProjectUsed không được trống?", PBean.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProjectUsed.Focus();
                return;
            }
            if (status == 1)
            {
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    //Thêm mới dữ liệu
                    dc.Open();
                    Gitem = new MenuFunction();
                    Gitem.Id = Guid.NewGuid().ToString();
                    Gitem.Title = txtTitle.Text;
                    Gitem.ControllerName = txtControllerName.Text;
                    Gitem.AcctionName = txtAcctionName.Text;
                    Gitem.ControllerNameApi = txtControllerNameApi.Text;
                    Gitem.AcctionNameApi = txtAcctionNameApi.Text;
                    Gitem.RouteId = txtRouteId.Text;
                    Gitem.IsMenu = chbIsMenu.Checked;
                    Gitem.IsPublic = chbIsPublic.Checked;
                    Gitem.Icon = txtIcon.Text;
                    Gitem.CssClass = txtCssClass.Text;
                    Gitem.Parrent = txtParrent.Text;
                    Gitem.Status = 0;
                    Gitem.CreateDate = DateTime.Now;
                    Gitem.SortIndex = Int32.Parse(txtSortIndex.Text, System.Globalization.NumberStyles.AllowThousands);
                    Gitem.Note = txtNote.Text;
                    Gitem.ProjectUsed = cmbProjectUsed.SelectedIndex;
                    Gitem.FK_MenuGroup = cmbNhomRibbonBar.SelectedValue.ToString();
                    Gitem.MenuWidth = Int32.Parse(txtMenuWidth.Text, System.Globalization.NumberStyles.AllowThousands);
                    Gitem.MenuImageName = txtMenuImageName.Text;
                    if (!string.IsNullOrEmpty(safeName))
                    {
                        if (!string.IsNullOrEmpty(safeName))
                        {
                            Gitem.FK_MenuImage = safeName;
                            MenuImage _gallery = dc.MEnuimage.GetObject(PBean.SCHEMA, Gitem.Id);
                            if (_gallery != null)
                            {
                                _gallery.CreateDate = DateTime.Now;
                                _gallery.FullName = Gitem.ControllerName;
                                Image bmp = PCommon.ImageFromFile(txtMenuImageName.Text);
                                System.Drawing.Imaging.ImageFormat format = PCommon.GetImageFormat(txtMenuImageName.Text);
                                Bitmap bitmap = ResizeImage(bmp, 45, 45);
                                _gallery.ImageString = PCommon.ImageToBase64(bitmap, format);
                                _gallery.CreateUser = PBean.USER.Id;
                                dc.MEnuimage.Update(PBean.SCHEMA, _gallery);
                            }
                            else
                            {
                                _gallery = new MenuImage();
                                _gallery.Id = Gitem.Id;
                                _gallery.FullName = Gitem.ControllerName;
                                _gallery.CreateDate = DateTime.Now;
                                Image bmp = PCommon.ImageFromFile(txtMenuImageName.Text);
                                System.Drawing.Imaging.ImageFormat format = PCommon.GetImageFormat(txtMenuImageName.Text);
                                Bitmap bitmap = ResizeImage(bmp, 45, 45);
                                _gallery.ImageString = PCommon.ImageToBase64(bitmap, format);
                                _gallery.CreateUser = PBean.USER.Id;
                                dc.MEnuimage.InsertOnSubmit(PBean.SCHEMA, _gallery);
                            }
                        }
                    }

                    //Gitem.FK_MenuImage = txtFK_MenuImage.Text;
                    Gitem.CreateUser = PBean.USER.Id;
                    Gitem.UpdateUser = PBean.USER.Id;
                    Gitem.FormShowType = cmbShowType.SelectedIndex;
                    dc.MEnufunction.InsertOnSubmit(PBean.SCHEMA, Gitem);
                    dc.SubmitChanges();
                    status = 0;
                    EnableButton(status);
                    LoadData();

                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                }
                finally
                {
                    dc.Close();
                }
            }
            else
            {
                if (status == 2)
                {
                    //Cập nhật dữ liệu
                    IDataContext dc = PCommon.getDataContext();
                    try
                    {
                        dc.Open();
                        Gitem.Title = txtTitle.Text;
                        Gitem.ControllerName = txtControllerName.Text;
                        Gitem.AcctionName = txtAcctionName.Text;
                        Gitem.ControllerNameApi = txtControllerNameApi.Text;
                        Gitem.AcctionNameApi = txtAcctionNameApi.Text;
                        Gitem.RouteId = txtRouteId.Text;
                        Gitem.IsMenu = chbIsMenu.Checked;
                        Gitem.IsPublic = chbIsPublic.Checked;
                        Gitem.Icon = txtIcon.Text;
                        Gitem.CssClass = txtCssClass.Text;
                        Gitem.Parrent = txtParrent.Text;
                        Gitem.SortIndex = Int32.Parse(txtSortIndex.Text, System.Globalization.NumberStyles.AllowThousands);
                        Gitem.Note = txtNote.Text;
                        Gitem.ProjectUsed = cmbProjectUsed.SelectedIndex;
                        Gitem.FK_MenuGroup = cmbNhomRibbonBar.SelectedValue.ToString();
                        Gitem.MenuWidth = Int32.Parse(txtMenuWidth.Text, System.Globalization.NumberStyles.AllowThousands);
                        Gitem.MenuImageName = txtMenuImageName.Text;
                        if (!string.IsNullOrEmpty(safeName))
                        {
                            if (!string.IsNullOrEmpty(safeName))
                            {
                                Gitem.MenuImageName = safeName;
                                MenuImage _gallery = dc.MEnuimage.GetObject(PBean.SCHEMA, Gitem.Id);
                                if (_gallery != null)
                                {
                                    _gallery.FullName = Gitem.ControllerName;
                                    _gallery.CreateDate = DateTime.Now;
                                    Image bmp = PCommon.ImageFromFile(txtMenuImageName.Text);
                                    System.Drawing.Imaging.ImageFormat format = PCommon.GetImageFormat(txtMenuImageName.Text);
                                    Bitmap bitmap = ResizeImage(bmp, 45, 45);
                                    _gallery.ImageString = PCommon.ImageToBase64(bitmap, format);
                                    _gallery.CreateUser = PBean.USER.Id;
                                    dc.MEnuimage.Update(PBean.SCHEMA, _gallery);
                                }
                                else
                                {
                                    _gallery = new MenuImage();
                                    _gallery.Id = Gitem.Id;
                                    _gallery.FullName = Gitem.ControllerName;
                                    _gallery.CreateDate = DateTime.Now;
                                    _gallery.CreateUser = PBean.USER.Id;
                                    Image bmp = PCommon.ImageFromFile(txtMenuImageName.Text);
                                    System.Drawing.Imaging.ImageFormat format = PCommon.GetImageFormat(txtMenuImageName.Text);
                                    Bitmap bitmap = ResizeImage(bmp, 45, 45);
                                    _gallery.ImageString = PCommon.ImageToBase64(bitmap, format);
                                    dc.MEnuimage.InsertOnSubmit(PBean.SCHEMA, _gallery);
                                }
                            }
                        }
                        Gitem.UpdateUser = PBean.USER.Id;
                        Gitem.FormShowType = cmbShowType.SelectedIndex;
                        dc.MEnufunction.Update(PBean.SCHEMA, Gitem);
                        dc.SubmitChanges();
                        status = 0;
                        EnableButton(status);
                        LoadData();

                    }
                    catch (Exception ex)
                    {
                        log.Error(ex);
                        MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                    }
                    finally
                    {
                        dc.Close();
                    }
                }
            }
        }

        //Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridMain.SelectedRows[0].Index;
                IDataContext dc = PCommon.getDataContext();
                try
                {
                    dc.Open();
                    Gitem = dc.MEnufunction.GetObject(PBean.SCHEMA, Convert.ToString(gridMain.Rows[index].Cells["col_Id"].Value));
                    if (null != Gitem)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa không?", PBean.MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dc.MEnufunctionaccount.DeleteOnSubmitCon(PBean.SCHEMA, "where FK_MenuFunction=@FK_MenuFunction", "@FK_MenuFunction", Gitem.Id);
                            dc.MEnufunction.DeleteOnSubmit(PBean.SCHEMA, Gitem);
                            dc.SubmitChanges();
                        }
                        Gitem = null;
                        status = 0;
                        EnableButton(status);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
                }
                finally
                {
                    dc.Close();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }
        //Kết thúc
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        private void cmbParent_SelectedIndexChanged(object sender, EventArgs e)
        {

            IDataContext dc = PCommon.getDataContext();
            try
            {
                dc.Open();
                cmbNhomRibbonBar.DataSource = dc.MEnufunctiongroup.GetListObjectCon(PBean.SCHEMA, "WHERE FK_MenuGroup=@FK_MenuGroup",
                     "@FK_MenuGroup", cmbParent.SelectedValue.ToString());
                cmbNhomRibbonBar.DisplayMember = "GroupName";
                cmbNhomRibbonBar.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MessageBox.Show(ex.ToString(), PBean.MESSAGE_TITLE);
            }
            finally
            {
                dc.Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files| *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Title = "Select a Cursor File";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtMenuImageName.Text = openFileDialog1.FileName;
                string fileName = openFileDialog1.FileName;
                safeName = openFileDialog1.SafeFileName;
            }
            else
            {
                safeName = string.Empty;
            }
        }
    }
}
