import { Button } from '@mui/material';
import React from 'react';


const LoggedPage: React.FC = () => {
  const handleSubmit = async (e:React.MouseEvent<HTMLElement>) => {
    e.preventDefault();
    try {
      const response = await fetch("https://localhost:7017/api/Test/", {
        method: "GET",
        headers: {
          "Content-Type": "application/json",
        },
        credentials: "include"
      });

      if (!response.ok) {
        const errorText = await response.text();
        throw new Error(errorText); 
      }

    } catch (error: unknown) { 
      console.error(error)
    }

  }
  return (
    <div>
      <h1>JESTEŚ ZALOGOWANY!</h1>
      <Button variant="contained" color="primary" onClick={
        handleSubmit
      }>
        Cokolwiek
      </Button>
    </div>
  );
};

export default LoggedPage;
