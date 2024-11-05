import { Checkbox } from "@mui/material";
import { GridRenderCellParams } from "@mui/x-data-grid";

const RenderCheckBox = (props: GridRenderCellParams) => {
  const { id, value, field, api } = props;

  const handleCheckboxChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const updatedValue = event.target.checked;
    api.setEditCellValue({ id, field, value: updatedValue });
  };

  return (
    <Checkbox
      size="medium"
      checked={value}
      onChange={handleCheckboxChange}
      style={{ margin: "0 auto", display: "block" }}
    />
  );
};

export default RenderCheckBox;
