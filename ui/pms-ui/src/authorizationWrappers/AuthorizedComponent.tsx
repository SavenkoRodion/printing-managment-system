import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

const AuthorizedComponent = ({ children }: { children: JSX.Element }) => {
  const [isLoading, setIsLoading] = useState(false);
  const navigate = useNavigate();

  useEffect(() => {
    setIsLoading(true);
    fetch("https://localhost:7017/api/auth/who-am-i", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
      },
      credentials: "include",
    }).then((e) => {
      e.status === 200 ? setIsLoading(false) : navigate("/");
    });
  }, [navigate]);
  return <>{isLoading ? "Loading..." : children}</>;
};

export default AuthorizedComponent;
