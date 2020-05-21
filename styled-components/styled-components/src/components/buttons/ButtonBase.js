import React from "react";
import styled from "styled-components";

const Button = styled.button`
  font-size: 1rem;
  width: 150px;
  border-radius: 25px;
  padding: 0.75em 1em;
  font-weight: 500;
  outline: none;

  &:hover {
    cursor: pointer;
  }

  &:disabled {
    opacity: 0.65;
  }
`;

const ButtonBase = ({ text, onClick, className }) => {
  return (
    <Button className={className} onClick={onClick}>
      {text}
    </Button>
  );
};

export default ButtonBase;
