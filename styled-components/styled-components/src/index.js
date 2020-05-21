import React from "react";
import ReactDOM from "react-dom";
import App from "./App";
import * as serviceWorker from "./serviceWorker";
import { createGlobalStyle, ThemeProvider } from "styled-components";

const GlobalStyle = createGlobalStyle`

`;

const theme = {
  font: {
    color: 'rgba(0, 0, 0, 0.8)',
    family: 'ubuntu',
    h1Size: '30px',
    h2Size: '26px',
    pSize: '18px'
  },
  spacing: {
    related: '30px',
    unrelated: '60px'
  },
  color: {
    primary: '#b969a9',
    secondary: '#ef3e3a'
  }
}

ReactDOM.render(
  <React.StrictMode>
    <ThemeProvider theme={theme}>
      <GlobalStyle />
      <App />
    </ThemeProvider>
  </React.StrictMode>,
  document.getElementById("root")
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
