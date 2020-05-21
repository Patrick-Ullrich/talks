import React, { useEffect, useState } from "react";
import LoadingIndicator from "../LoadingIndicator/LoadingIndicator";
import styled from "styled-components";
import Button from "../buttons/ButtonBase";
import PrimaryButton from "../buttons/PrimaryButton";

const BlogList = styled.ul`
  margin: 0;
  padding: 0;
  list-style: none;
`;

const Blog = styled.button`
  border: 1px solid #ccc;
  border-radius: 25px;
  padding: 1.25rem 1rem;
  text-align: left;
`;

const TopRow = styled.div``;

const Title = styled.h2``;

const Time = styled.span``;

const Preview = styled.p``;

const BlogListItem = styled.li`
  margin: ${(props) => props.theme.spacing.related} 0;

  > ${Blog} {
    :hover {
      cursor: ${(props) => (props.isOld ? "not-allowed" : "pointer")};
    }
  }
`;

const Blogs = () => {
  const [isLoading, setLoading] = useState(true);
  const [blogs, setBlogs] = useState([]);

  // Getting Blog Posts
  useEffect(() => {
    setLoading(true);
    // setTimeout(() => {
    //   setBlogs([
    //     {
    //       id: "c",
    //       name: "I ❤️ CSS-IN-JS",
    //       isOld: false,
    //       length: 30,
    //       preview:
    //         "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas nibh lacus, euismod ac nibh eget, finibus volutpat tortor. Morbi nibh urna, dictum ut enim ac, tristique posuere diam. Maecenas condimentum posuere sem ut auctor. Mauris hendrerit enim nec elit faucibus",
    //     },
    //     {
    //       id: "b",
    //       name: "CSS-IN-JS - What is it about?",
    //       isOld: false,
    //       length: 12,
    //       preview:
    //         "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas nibh lacus, euismod ac nibh eget, finibus volutpat tortor. Morbi nibh urna, dictum ut enim ac, tristique posuere diam. Maecenas condimentum posuere sem ut auctor. Mauris hendrerit enim nec elit faucibus",
    //     },
    //     {
    //       id: "a",
    //       name: "Use CSS in React!!!",
    //       isOld: true,
    //       length: 10,
    //       preview:
    //         "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas nibh lacus, euismod ac nibh eget, finibus volutpat tortor. Morbi nibh urna, dictum ut enim ac, tristique posuere diam. Maecenas condimentum posuere sem ut auctor. Mauris hendrerit enim nec elit faucibus",
    //     },
    //   ]);
    //   setLoading(false);
    // }, 2000);
  }, []);

  return isLoading ? (
    <div className="center-container">
      <LoadingIndicator />
    </div>
  ) : blogs.length === 0 ? (
    <p>No Blog posts.</p>
  ) : (
    <>
      <BlogList>
        {blogs.map((blog) => (
          <BlogListItem key={blog.id} isOld={blog.isOld}>
            <Blog>
              <TopRow>
                <Title>{blog.name}</Title>
                <Time>{blog.length} min</Time>
              </TopRow>

              <Preview>{blog.preview}</Preview>
            </Blog>
          </BlogListItem>
        ))}
      </BlogList>
      <div className="button-row">
        <Button type="secondary" text="Previous" />
        <PrimaryButton type="primary" text="Next" />
      </div>
    </>
  );
};

export default Blogs;
