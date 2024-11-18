import React, { useState } from "react";
import { Container, Box, ToggleButton, ToggleButtonGroup } from "@mui/material";
import EditorView from "./EditorView";
import EditorTab from "./EditorTab";
import InfoView from "./InfoView";

export type EditorParams = { projectId: string; type: "template" | "project" };

const Editor = () => {
  const [editorTab, setEditorTab] = useState<EditorTab>(EditorTab.Info);

  const handleViewChange = (
    _event: React.MouseEvent<HTMLElement>,
    newTab: EditorTab
  ) => {
    if (newTab !== null) {
      setEditorTab(newTab);
    }
  };

  return (
    <Container>
      <Box display="flex" justifyContent="center" mb={2}>
        <ToggleButtonGroup
          value={editorTab}
          exclusive
          onChange={handleViewChange}
          aria-label="view selection"
        >
          <ToggleButton value={EditorTab.Info} aria-label="info view">
            Info
          </ToggleButton>
          <ToggleButton value={EditorTab.Editor} aria-label="editor view">
            Edytor
          </ToggleButton>
        </ToggleButtonGroup>
      </Box>
      {editorTab === EditorTab.Info && <InfoView />}
      {editorTab === EditorTab.Editor && <EditorView />}
    </Container>
  );
};

export default Editor;
