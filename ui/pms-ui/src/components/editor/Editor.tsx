import React, { useState } from "react";
import { Container, Box, ToggleButton, ToggleButtonGroup } from "@mui/material";
import InfoView from "./InfoView";
import EditorView from "./EditorView";
import { View } from "./views";

const Editor = () => {
  const [view, setView] = useState<View>(View.Info);

  const handleViewChange = (
    _event: React.MouseEvent<HTMLElement>,
    newView: View
  ) => {
    if (newView !== null) {
      setView(newView);
    }
  };

  return (
    <Container>
      <Box display="flex" justifyContent="center" mb={2}>
        <ToggleButtonGroup
          value={view}
          exclusive
          onChange={handleViewChange}
          aria-label="view selection"
        >
          <ToggleButton value={View.Info} aria-label="info view">
            Info
          </ToggleButton>
          <ToggleButton value={View.Editor} aria-label="editor view">
            Edytor
          </ToggleButton>
        </ToggleButtonGroup>
      </Box>
      {view === View.Info && <InfoView />}
      {view === View.Editor && <EditorView />}
    </Container>
  );
};

export default Editor;
