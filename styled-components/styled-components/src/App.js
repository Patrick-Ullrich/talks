import React from 'react';
import Header from "./components/Header/Header";
import Blogs from "./components/Blogs/Blogs";

function App() {
  return (
    <div>
      <Header />
      <div className="main">
        <Blogs />
      </div>
    </div>
  );
}

export default App;
