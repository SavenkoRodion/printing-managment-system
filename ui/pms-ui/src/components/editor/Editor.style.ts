export const styles = {
  container: {
    display: "flex",
    flexDirection: "row",
    gap: 4,
  },
  leftPanel: {
    width: "50%",
    display: "flex",
    flexDirection: "column",
    gap: 2,
  },
  rightPanel: {
    width: "50%",
    display: "flex",
    flexDirection: "column",
    gap: 2,
    alignItems: "center",
  },
  formControl: {
    width: "100%",
  },
  select: {
    minWidth: 200,
  },
  inputLabel: {
    mb: 1,
  },
  textField: {
    marginTop: 1,
  },
  buttonContainer: {
    marginTop: 2,
  },
  dataGridContainer: {
    marginTop: 2,
    height: 400,
  },
  fileButton: {
    mt: 1,
  },
  pdfContainer: {
    position: "relative",
    height: "flex",
    width: "100%",
    overflowX: "auto",
    overflowY: "hidden",
    border: "2px solid black",
    borderRadius: "8px",
    display: "flex",
    flexDirection: "column",
  },
  emptyPdfcontainer: {
    minHeight: "350px",
    border: "2px solid black",
    borderRadius: "8px",
    width: "100%",
    display: "flex",
    alignContent: "center",
    justifyContent: "center",
  },
  zoomControls: {
    display: "flex",
    justifyContent: "space-between",
    padding: 2,
  },
  zoomInfo: {
    display: "flex",
    alignItems: "center",
  },
  buttonsWrap: {
    display: "flex",
    flexWrap: "wrap",
    gap: 2,
  },
};
