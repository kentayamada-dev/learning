FROM openjdk:22-slim-bookworm

ENV TZ=Asia/Tokyo \
    SHELL=/bin/zsh

ARG USERNAME=dev
ARG USER_UID=1000
ARG USER_GID=$USER_UID

ARG WORKSPACE_PATH="/workspaces/JAVA"
ARG HOME="/home/${USERNAME}"
ARG CLONE="git clone --depth 1 --"
ARG APT="apt-get"
ARG UPDATE="${APT} update"
ARG INSTALL="${APT} -y install --no-install-recommends"

RUN groupadd --gid $USER_GID $USERNAME \
    && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME \
    && $UPDATE \
    && $INSTALL sudo zsh git \
    && echo $USERNAME ALL=\(root\) NOPASSWD:ALL > /etc/sudoers.d/$USERNAME \
    && chmod 0440 /etc/sudoers.d/$USERNAME

RUN rm -f $HOME/.zshrc && ln -s $WORKSPACE_PATH/.devcontainer/.zshrc $HOME/.zshrc \
    && $CLONE https://github.com/z-shell/F-Sy-H $HOME/fsh && $CLONE https://github.com/olets/zsh-abbr $HOME/abbr \
    && $UPDATE && $INSTALL exa fd-find fzf bat

USER $USERNAME
