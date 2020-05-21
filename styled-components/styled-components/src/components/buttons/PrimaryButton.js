import React from "react";
import styled from "styled-components";
import ButtonBase from "./ButtonBase";

const PrimaryButton = styled(ButtonBase)`
  border: none;
  background: #b969a9;
  background: -moz-linear-gradient(left, #b969a9 0%, #ef3e3a 100%);
  background: -webkit-gradient(
    left top,
    right top,
    color-stop(0%, #b969a9),
    color-stop(100%, #ef3e3a)
  );
  background: -webkit-linear-gradient(left, #b969a9 0%, #ef3e3a 100%);
  background: -o-linear-gradient(left, #b969a9 0%, #ef3e3a 100%);
  background: -ms-linear-gradient(left, #b969a9 0%, #ef3e3a 100%);
  background: linear-gradient(to right, #b969a9 0%, #ef3e3a 100%);
  filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#b969a9', endColorstr='#ef3e3a', GradientType=1 );
  color: #f2f2f2;
`;

const PrimaryButtonComponent = ({ text, onClick }) => {
  return <PrimaryButton onClick={onClick} text={text} />;
};

export default PrimaryButtonComponent;
