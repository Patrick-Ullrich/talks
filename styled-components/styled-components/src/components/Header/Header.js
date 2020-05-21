import React from "react";
import styled from "styled-components";

const Wrapper = styled.div`
  display: flex;
  width: 100%;
  height: 80px;
  background-color: #191919;
  justify-content: space-between;
  align-items: center;
`;

const Title = styled.h2`
  padding-left: 8vw;
  margin-right: 2rem;
  color: white;

  :hover {
    color: #ef3e3a;
    cursor: pointer;
  }
`;

const Header = () => {
  return (
    <Wrapper>
      <Title>Patricks Blog</Title>
    </Wrapper>
  );
};

export default Header;
